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
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// The automation library containing the automation for the toolkit.
	/// </summary>
	[Description("The automation library containing the automation for the toolkit.")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "fcfa4452-7e09-4f57-b35b-b9f1ee6179ca", ProxyType = typeof(AutomationLibrary))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.4.24.0")]
	public partial interface IAutomationLibrary : IToolkitInterface
	{

		/// <summary>
		/// The assembly name of the automation library project.
		/// </summary>
		[Description("The assembly name of the automation library project.")]
		[DisplayName("Project Assembly Name")]
		[Category("General")]
		String ProjectAssemblyName { get; set; }

		/// <summary>
		/// The name of the automation library project.
		/// </summary>
		[Description("The name of the automation library project.")]
		[DisplayName("Project Name")]
		[Category("General")]
		String ProjectName { get; set; }

		/// <summary>
		/// Gets or sets the ToolkitInfo property.
		/// </summary>
		IProductToolkitInfo ToolkitInfo { get; }

		/// <summary>
		/// Gets or sets the CurrentView property.
		/// </summary>
		IView CurrentView { get; set; }

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		String InstanceName { get; set; }

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		Double InstanceOrder { get; set; }

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get; }

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		Boolean InTransaction { get; }

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		Boolean IsSerializing { get; }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IAutomationCollection Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IProduct"/>) of this element.
		/// </summary>
		Runtime.IProduct AsProduct();
	}
}
