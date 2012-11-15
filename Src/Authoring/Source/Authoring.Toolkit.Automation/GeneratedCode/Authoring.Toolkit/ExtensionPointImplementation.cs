﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.Patterning.Authoring.Authoring
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Composition;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	The automation library containing the automation for the toolkit.
	///	</summary>
	[Description("The automation library containing the automation for the toolkit.")]
	[ToolkitInterfaceProxy(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "fcfa4452-7e09-4f57-b35b-b9f1ee6179ca", ProxyType = typeof(AutomationLibrary))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	internal partial class AutomationLibrary : IAutomationLibrary
	{
		private Runtime.IProduct target;
		private Runtime.IProductProxy<IAutomationLibrary> proxy;

		/// <summary>
		/// For MEF.
		/// </summary>
		[ImportingConstructor]
		private AutomationLibrary() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="AutomationLibrary"/> class.
		/// </summary>
		public AutomationLibrary(Runtime.IProduct target)
		{
			this.target = target;
			this.proxy = target.ProxyFor<IAutomationLibrary>();
			OnCreated();
		}	

		partial void OnCreated();

		///	<summary>
		///	The assembly name of the automation library project.
		///	</summary>
		[Description("The assembly name of the automation library project.")]
		[DisplayName("Project Assembly Name")]
		[Category("General")]
		public virtual String ProjectAssemblyName 
		{
			get { return this.proxy.GetValue(() => this.ProjectAssemblyName); }
			set { this.proxy.SetValue(() => this.ProjectAssemblyName, value); }
		}
		
		///	<summary>
		///	The ToolkitInfo.
		///	</summary>
		public virtual IProductToolkitInfo ToolkitInfo 
		{ 
			get { return this.proxy.GetValue(() => this.ToolkitInfo); }
		}
		
		///	<summary>
		///	The CurrentView.
		///	</summary>
		public virtual IView CurrentView 
		{ 
			get { return this.proxy.GetValue(() => this.CurrentView); }
			set { this.proxy.SetValue(() => this.CurrentView, value); }
		}
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		public virtual String InstanceName 
		{ 
			get { return this.proxy.GetValue(() => this.InstanceName); }
			set { this.proxy.SetValue(() => this.InstanceName, value); }
		}
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		public virtual Double InstanceOrder 
		{ 
			get { return this.proxy.GetValue(() => this.InstanceOrder); }
			set { this.proxy.SetValue(() => this.InstanceOrder, value); }
		}
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		public virtual IEnumerable<IReference> References 
		{ 
			get { return this.proxy.GetValue(() => this.References); }
		}
		
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public virtual String Notes 
		{ 
			get { return this.proxy.GetValue(() => this.Notes); }
			set { this.proxy.SetValue(() => this.Notes, value); }
		}
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		public virtual Boolean InTransaction 
		{ 
			get { return this.proxy.GetValue(() => this.InTransaction); }
		}
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		public virtual Boolean IsSerializing 
		{ 
			get { return this.proxy.GetValue(() => this.IsSerializing); }
		}
		/// <summary>
		/// Gets the parent element.
		/// </summary>
		public virtual IAutomationCollection Parent
		{ 
			get { return this.target.Parent.As<IAutomationCollection>(); }
		}

		/// <summary>
		/// Gets the generic <see cref="Runtime.IProduct"/> underlying element.
		/// </summary>
		public virtual Runtime.IProduct AsProduct()
		{
			return this.target;
		}

		/// <summary>
		/// Gets the generic underlying element as the given type if possible.
		/// </summary>
		public virtual TRuntimeInterface As<TRuntimeInterface>()
			where TRuntimeInterface : class
		{
			return this.target as TRuntimeInterface;
		}

		/// <summary>
		/// Deletes this instance.
		/// </summary>
		public virtual void Delete()
		{
			this.target.Delete();
		}
	}
}
