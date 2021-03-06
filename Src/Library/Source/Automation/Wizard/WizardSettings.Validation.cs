﻿using System;
using System.Globalization;
using Microsoft.VisualStudio.Modeling.Validation;
using NuPattern.Diagnostics;
using NuPattern.Library.Properties;
using NuPattern.Reflection;

namespace NuPattern.Library.Automation
{
    /// <summary>
    /// Custom validation rules.
    /// </summary>
    [ValidationState(ValidationState.Enabled)]
    partial class WizardSettings
    {
        private static readonly ITracer tracer = Tracer.Get<WizardSettings>();

        /// <summary>
        /// Validates that the TypeId is not empty, and exists.
        /// </summary>
        [ValidationMethod(ValidationCategories.Save | ValidationCategories.Menu)]
        internal void ValidateTypeNameNotEmpty(ValidationContext context)
        {
            try
            {
                // Ensure not empty
                if (string.IsNullOrEmpty(this.TypeName))
                {
                    context.LogError(
                        string.Format(
                            CultureInfo.CurrentCulture,
                            Resources.Validate_WizardSettingsTypeIsNotEmpty,
                            this.Name),
                        Resources.Validate_WizardSettingsTypeIsNotEmptyCode, this.Extends);
                }
            }
            catch (Exception ex)
            {
                tracer.Error(
                    ex,
                    Resources.ValidationMethodFailed_Error,
                    Reflector<WizardSettings>.GetMethod(n => n.ValidateTypeNameNotEmpty(context)).Name);

                throw;
            }
        }
    }
}