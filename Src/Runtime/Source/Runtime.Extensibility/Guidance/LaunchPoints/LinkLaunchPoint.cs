﻿using System;
using System.Globalization;
using System.Windows;
using NuPattern.Diagnostics;
using NuPattern.Runtime.Guidance.Workflow;
using NuPattern.Runtime.Properties;

namespace NuPattern.Runtime.Guidance.LaunchPoints
{
    /// <summary>
    /// A base class for launchpoints that are links in guidance content.
    /// </summary>
    public abstract class LinkLaunchPoint : ILaunchPoint
    {
        /// <summary>
        /// Gets the strategy for querying the status.
        /// </summary>
        protected virtual IQueryStatusStrategy QueryStatusStrategy { get; set; }

        /// <summary>
        /// Gets the <see cref="IGuidanceManager"/>.
        /// </summary>
        protected IGuidanceManager GuidanceManager;

        /// <summary>
        /// Creates a new instance of the <see cref="LinkLaunchPoint"/> class.
        /// </summary>
        protected LinkLaunchPoint(IGuidanceManager guidanceManager)
        {
            Guard.NotNull(() => guidanceManager, guidanceManager);
            GuidanceManager = guidanceManager;
            this.QueryStatusStrategy = new DefaultQueryStatusStrategy(this.GetType().Name);
        }

        /// <summary>
        /// Gets the name of the binding.
        /// </summary>
        protected abstract string BindingName { get; }

        /// <summary>
        /// Whether the binding can be executed.
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public virtual bool CanExecute(IGuidanceExtension extension)
        {
            if (extension != null && this.QueryStatusStrategy.QueryStatus(extension).Enabled)
            {
                // Verify the action is enabled.
                var activeWorkflow = extension.GuidanceWorkflow != null ? extension.GuidanceWorkflow : GuidanceManager.ActiveGuidanceExtension.GuidanceWorkflow;
                if (activeWorkflow != null)
                {
                    var node = activeWorkflow.FocusedAction as INode;
                    if (node.State == NodeState.Enabled)
                        return true;
                }
            }

            NotifyUser();

            return false;
        }

        /// <summary>
        /// This method is called by CanExecute when a link is clicked but can't execute.
        /// Authors can override this method to provide custom notification
        /// </summary>
        public virtual void NotifyUser()
        {
            MessageBox.Show(Resources.LinkLaunchPoint_NotifyUser);
        }

        /// <summary>
        /// Executes the binding
        /// </summary>
        /// <param name="extension"></param>
        public virtual void Execute(IGuidanceExtension extension)
        {
            if (!this.CanExecute(extension))
            {
                throw new InvalidOperationException(string.Format(
                    CultureInfo.CurrentCulture,
                    Resources.LinkLaunchPoint_ErrorCommandCannotExecute,
                    this.BindingName));
            }

            var tracer = Tracer.Get<LinkLaunchPoint>();

            using (tracer.StartActivity(Resources.LinkLaunchPoint_TraceExecute, BindingName))
            {
                var commandBinding = extension.Commands.FindByName(this.BindingName);
                if (commandBinding != null)
                {
                    commandBinding.Evaluate();
                    commandBinding.Value.Execute();
                }
            }
        }
    }
}