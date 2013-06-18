﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuPattern.Authoring.PatternToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Composition;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// The automation library containing the automation for the toolkit.
	/// </summary>
	[Description("The automation library containing the automation for the toolkit.")]
	[ToolkitInterfaceProxy(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "fcfa4452-7e09-4f57-b35b-b9f1ee6179ca", ProxyType = typeof(AutomationLibrary))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	internal partial class AutomationLibrary : IAutomationLibrary
	{

		private Runtime.IProduct target;
		private IProductProxy<IAutomationLibrary> proxy;

		/// <summary>
		/// Creates a new instance of the <see cref="AutomationLibrary"/> class.
		/// </summary>
		[ImportingConstructor]
		private AutomationLibrary() { }

		/// <summary>
		/// Creates a new instance of the <see cref="AutomationLibrary"/> class.
		/// </summary>
		public AutomationLibrary(Runtime.IProduct target)
		{
			this.target = target;
			this.proxy = target.ProxyFor<IAutomationLibrary>();
			OnCreated();
		}

		/// <summary>
		/// When overridden, initializes the class.
		/// </summary>
		partial void OnCreated();

		/// <summary>
		/// The assembly name of the automation library project.
		/// </summary>
		[Description("The assembly name of the automation library project.")]
		[DisplayName("Project Assembly Name")]
		[Category("General")]
		public virtual String ProjectAssemblyName
		{
			get { return this.proxy.GetValue(() => this.ProjectAssemblyName); }
			set { this.proxy.SetValue(() => this.ProjectAssemblyName, value); }
		}

		/// <summary>
		/// The name of the automation library project.
		/// </summary>
		[Description("The name of the automation library project.")]
		[DisplayName("Project Name")]
		[Category("General")]
		public virtual String ProjectName
		{
			get { return this.proxy.GetValue(() => this.ProjectName); }
			set { this.proxy.SetValue(() => this.ProjectName, value); }
		}

		/// <summary>
		/// Gets or sets the ToolkitInfo property.
		/// </summary>
		public virtual IProductToolkitInfo ToolkitInfo
		{ 
			get { return this.proxy.GetValue(() => this.ToolkitInfo); }
		}

		/// <summary>
		/// Gets or sets the CurrentView property.
		/// </summary>
		public virtual IView CurrentView
		{ 
			get { return this.proxy.GetValue(() => this.CurrentView); }
			set { this.proxy.SetValue(() => this.CurrentView, value); }
		}

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		public virtual String InstanceName
		{ 
			get { return this.proxy.GetValue(() => this.InstanceName); }
			set { this.proxy.SetValue(() => this.InstanceName, value); }
		}

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		public virtual Double InstanceOrder
		{ 
			get { return this.proxy.GetValue(() => this.InstanceOrder); }
			set { this.proxy.SetValue(() => this.InstanceOrder, value); }
		}

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		public virtual IEnumerable<IReference> References
		{ 
			get { return this.proxy.GetValue(() => this.References); }
		}

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public virtual String Notes
		{ 
			get { return this.proxy.GetValue(() => this.Notes); }
			set { this.proxy.SetValue(() => this.Notes, value); }
		}

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		public virtual Boolean InTransaction
		{ 
			get { return this.proxy.GetValue(() => this.InTransaction); }
		}

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
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
		/// Deletes this element.
		/// </summary>
		public virtual void Delete()
		{
			this.target.Delete();
		}

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IProduct"/>) of this element.
		/// </summary>
		public virtual Runtime.IProduct AsProduct()
		{
			return this.target;
		}

		/// <summary>
		/// Gets the specified generalized interface of this element, if possible.
		/// </summary>
		public virtual TGeneralizedInterface As<TGeneralizedInterface>() where TGeneralizedInterface : class
		{
			return this.target as TGeneralizedInterface;
		}
	}
}
