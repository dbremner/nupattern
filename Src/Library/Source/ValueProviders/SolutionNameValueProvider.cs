﻿using System;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;
using NuPattern.ComponentModel.Design;
using NuPattern.Diagnostics;
using NuPattern.Library.Properties;
using NuPattern.Runtime;
using NuPattern.VisualStudio.Solution;

namespace NuPattern.Library.ValueProviders
{
    /// <summary>
    /// A <see cref=" ValueProvider"/> that provides solution name.
    /// </summary>
    [DisplayNameResource(@"SolutionNameValueProvider_DisplayName", typeof(Resources))]
    [DescriptionResource(@"SolutionNameValueProvider_Description", typeof(Resources))]
    [CategoryResource(@"AutomationCategory_VisualStudio", typeof(Resources))]
    [CLSCompliant(false)]
    public class SolutionNameValueProvider : ValueProvider
    {
        private static readonly ITracer tracer = Tracer.Get<SolutionNameValueProvider>();

        /// <summary>
        /// The current solution.
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public ISolution Solution
        {
            get;
            set;
        }

        /// <summary>
        /// Evaluates this provider.
        /// </summary>
        public override object Evaluate()
        {
            this.ValidateObject();

            tracer.Info(
                Resources.SolutionNameValueProvider_TraceInitial);

            var result = this.Solution.Name;

            tracer.Info(
                Resources.SolutionNameValueProvider_TraceEvaluation, result);

            return result;
        }
    }
}