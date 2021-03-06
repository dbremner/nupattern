using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using NuPattern.Runtime.Guidance.Workflow;
using NuPattern.VisualStudio.Solution;

namespace NuPattern.Runtime.Guidance.Extensions
{
    /// <summary>
    /// A guidance extension that does not persist its state
    /// </summary>
    /// <typeparam name="TGeneratedWorkflow"></typeparam>
    public class StatelessGuidanceExtension<TGeneratedWorkflow> : StatelessGuidanceExtension
        where TGeneratedWorkflow : GuidanceWorkflow, new()
    {
        /// <summary>
        /// Gets the commands for the extension
        /// </summary>
        public override IEnumerable<ICommandBinding> Commands
        {
            get { yield break; }
        }

        /// <summary>
        /// Called to create the workflow.
        /// </summary>
        /// <returns></returns>
        protected internal override IGuidanceWorkflow OnCreateWorkflow()
        {
            var workflow = new TGeneratedWorkflow();
            this.GuidanceComposition.SatisfyImportsOnce(workflow);
            workflow.OwningExtension = this;
            workflow.Initialize();

            return workflow;
        }
    }

    /// <summary>
    /// A guidance extension that does not persist its state
    /// </summary>
    public abstract class StatelessGuidanceExtension : GuidanceExtension, IDisposable
    {
        /// <summary>
        /// Disposes this instance
        /// </summary>
        ~StatelessGuidanceExtension()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Gets the project for this extension
        /// </summary>
        public IProject Project { get; private set; }

        /// <summary>
        /// Called to create the workflow for this guidance extension
        /// </summary>
        /// <returns></returns>
        protected internal abstract IGuidanceWorkflow OnCreateWorkflow();

        /// <summary>
        /// Disposes this instance
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Creates the workflow for this instance
        /// </summary>
        /// <returns></returns>
        public override IGuidanceWorkflow CreateWorkflow()
        {
            var workflow = this.OnCreateWorkflow();
            return workflow;
        }

        /// <summary>
        /// Disposes this instance
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
        }

        /// <summary>
        /// Called after the extension is finished
        /// </summary>
        protected internal override void OnFinish()
        {
        }

        /// <summary>
        /// Called when an instance is created.
        /// </summary>
        protected internal override void OnInstantiate()
        {
        }
    }
}