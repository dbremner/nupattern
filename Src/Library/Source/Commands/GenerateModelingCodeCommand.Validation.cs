﻿using System;
using System.ComponentModel.Composition;
using System.Globalization;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;
using Microsoft.VisualStudio.Shell;
using NuPattern.Diagnostics;
using NuPattern.Library.Automation;
using NuPattern.Library.Properties;
using NuPattern.Reflection;
using NuPattern.Runtime;
using NuPattern.VisualStudio.Solution;

namespace NuPattern.Library.Commands
{
    /// <summary>
    /// Validations for the <see cref="GenerateModelingCodeCommand"/> command
    /// </summary>
    [CommandValidationRule(typeof(GenerateModelingCodeCommand))]
    public class GenerateModelingCodeCommandValidation : ICommandValidationRule
    {
        private static readonly ITracer tracer = Tracer.Get<UnfoldVsTemplateCommandValidation>();

        [Import(typeof(SVsServiceProvider))]
        internal IServiceProvider serviceProvider
        {
            get;
            set;
        }

        /// <summary>
        /// Called when validations are needed for the command
        /// </summary>
        /// <param name="context">Validation Context where to add validation errors</param>
        /// <param name="settingsElement">The settings element in the model being validated</param>
        /// <param name="settings">Settings for the command</param>
        public virtual void Validate(ValidationContext context, IAutomationSettingsSchema settingsElement, ICommandSettings settings)
        {
            Guard.NotNull(() => context, context);
            Guard.NotNull(() => settings, settings);

            try
            {
                var authoringUriString = settings.GetPropertyValue<string>(Reflector<GenerateModelingCodeCommand>.GetPropertyName(u => u.TemplateAuthoringUri));
                if (!string.IsNullOrEmpty(authoringUriString))
                {
                    var authoringUri = new Uri(authoringUriString);
                    var uriService = serviceProvider.GetService<IUriReferenceService>();
                    IItem item = null;
                    try
                    {
                        item = uriService.ResolveUri<IItemContainer>(authoringUri).As<IItem>();
                    }
                    catch (NotSupportedException)
                    {
                        LogSolutionItemNotFound(context, settingsElement, settings);
                        return;
                    }
                    catch (UriFormatException)
                    {
                        LogSolutionItemNotFound(context, settingsElement, settings);
                        return;
                    }

                    // Ensure file is configured as 'Content'
                    if (!(string.Equals(item.Data.ItemType, BuildAction.Content.ToString(), StringComparison.OrdinalIgnoreCase)))
                    {
                        context.LogError(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            Resources.Validate_GenerateModelingCodeCommandItemTypeShouldBeSetToContent,
                            settings.Name),
                        Resources.Validate_GenerateModelingCodeCommandItemTypeShouldBeSetToContentCode, settingsElement as ModelElement);
                    }

                    // Ensure file is 'IncludeInVSIX'
                    if (!(string.Equals(item.Data.IncludeInVSIX, Boolean.TrueString.ToUpperInvariant(), StringComparison.OrdinalIgnoreCase)))
                    {
                        if (String.IsNullOrEmpty(item.Data.IncludeInVSIXAs))
                        {
                            context.LogError(
                            string.Format(
                                CultureInfo.CurrentCulture,
                                Resources.Validate_GenerateModelingCodeCommandIIncludeInVSIXShouldBeSetToTrue,
                                settings.Name),
                            Resources.Validate_GenerateModelingCodeCommandIIncludeInVSIXShouldBeSetToTrueCode, settingsElement as ModelElement);
                        }
                        else
                        {
                            // Ensure the 'IncludeInVSIXAs' value matches TemplateUri value
                            var templateUriString = settings.GetPropertyValue<string>(Reflector<GenerateModelingCodeCommand>.GetPropertyName(u => u.TemplateUri));
                            if (!String.IsNullOrEmpty(templateUriString))
                            {
                                var templateFilename = TextTemplateUri.ParseFileName(new Uri(templateUriString));
                                if (!templateFilename.Equals(item.Data.IncludeInVSIXAs, StringComparison.OrdinalIgnoreCase))
                                {
                                    context.LogError(
                                    string.Format(
                                        CultureInfo.CurrentCulture,
                                        Resources.Validate_GenerateModelingCodeCommandIIncludeInVSIXAsShouldBeSameAsFile,
                                        settings.Name),
                                    Resources.Validate_GenerateModelingCodeCommandIIncludeInVSIXAsShouldBeSameAsFileCode, settingsElement as ModelElement);
                                }
                            }
                        }
                    }
                    else
                    {
                        // Ensure not both 'IncludeInVSIX' and 'IncludeInVSIXAs'
                        if (!String.IsNullOrEmpty(item.Data.IncludeInVSIXAs))
                        {
                            context.LogError(
                            string.Format(
                                CultureInfo.CurrentCulture,
                                Resources.Validate_GenerateModelingCodeCommandIIncludeInVSIXDuplicate,
                                settings.Name),
                            Resources.Validate_GenerateModelingCodeCommandIIncludeInVSIXDuplicateCode, settingsElement as ModelElement);
                        }
                    }
                }
                else
                {
                    LogSolutionItemNotFound(context, settingsElement, settings);
                    return;
                }

                var targetFilename = settings.GetPropertyValue<string>(Reflector<GenerateModelingCodeCommand>.GetPropertyName(u => u.TargetFileName));
                if (string.IsNullOrEmpty(targetFilename))
                {
                    context.LogError(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Validate_GenerateModelingCodeCommandTargetFilenameEmpty,
                        settings.Name),
                    Resources.Validate_GenerateModelingCodeCommandTargetFilenameEmptyCode, settingsElement as ModelElement);
                }

                var isConfiguredOnProduct = ((settingsElement.Parent as IPatternSchema) != null);
                var targetPath = settings.GetPropertyValue<string>(Reflector<GenerateModelingCodeCommand>.GetPropertyName(u => u.TargetPath));
                if ((!string.IsNullOrEmpty(targetPath))
                    && (targetPath.StartsWith(PathResolver.ResolveArtifactLinkCharacter, StringComparison.OrdinalIgnoreCase))
                    && !isConfiguredOnProduct)
                {
                    context.LogWarning(
                    string.Format(
                        CultureInfo.CurrentCulture,
                        Resources.Validate_GenerateModelingCodeCommandTargetPathStartsWithResolver,
                        settings.Name, targetPath, PathResolver.ResolveArtifactLinkCharacter),
                    Resources.Validate_GenerateModelingCodeCommandTargetPathStartsWithResolverCode, settingsElement as ModelElement);
                }
            }
            catch (Exception ex)
            {
                tracer.Error(
                    ex,
                    Resources.ValidationMethodFailed_Error,
                    Reflector<GenerateModelingCodeCommandValidation>.GetMethod(n => n.Validate(null, null, null)).Name);

                throw;
            }
        }

        private static void LogSolutionItemNotFound(ValidationContext context, IAutomationSettingsSchema settingsElement, ICommandSettings settings)
        {
            if (!settings.Owner.Root.PatternModel.IsInTailorMode())
            {
                //item not found error
                context.LogError(
                string.Format(
                    CultureInfo.CurrentCulture,
                    Resources.Validate_GenerateModelingCodeAuthoringUriIsInvalid,
                    settings.Name),
                Resources.Validate_GenerateModelingCodeAuthoringUriIsInvalidCode, settingsElement as ModelElement);
            }
        }
    }
}
