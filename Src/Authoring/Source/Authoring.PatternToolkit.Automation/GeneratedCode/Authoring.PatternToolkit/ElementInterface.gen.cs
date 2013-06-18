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
	/// A Visual Studio item template.
	/// </summary>
	[Description("A Visual Studio item template.")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "7475fa2d-8033-461c-a460-7e0793491874", ProxyType = typeof(ItemTemplate))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface IItemTemplate : IToolkitInterface
	{

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
		IItemTemplates Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

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
	/// A Visual Studio project template
	/// </summary>
	[Description("A Visual Studio project template")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "f03d48a2-2377-4e56-a2c4-ae24d34302d3", ProxyType = typeof(ProjectTemplate))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface IProjectTemplate : IToolkitInterface
	{

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
		IProjectTemplates Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

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
	/// A custom T4 text template.
	/// </summary>
	[Description("A custom T4 text template.")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "c6a0f8d4-59df-4dad-b92e-c6a1e54be5e2", ProxyType = typeof(TextTemplate))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface ITextTemplate : IToolkitInterface
	{

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
		ITextTemplates Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

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
	/// A custom wizard.
	/// </summary>
	[Description("A custom wizard.")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "b013c2ba-e9e0-484d-a0bc-e821c38c192b", ProxyType = typeof(Wizard))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface IWizard : IToolkitInterface
	{

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
		IWizards Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

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
	/// A custom wizard page
	/// </summary>
	[Description("A custom wizard page")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "93ee656b-6308-42d1-a5d7-e10fcea47ee7", ProxyType = typeof(WizardPage))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface IWizardPage : IToolkitInterface
	{

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
		IWizardPages Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

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
	/// Guidance for the toolkit.
	/// </summary>
	[Description("Guidance for the toolkit.")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "c3d66aa5-3199-44ad-b7d7-f375a9ab16d3", ProxyType = typeof(Guidance))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface IGuidance : IToolkitInterface
	{

		/// <summary>
		/// A relative path in the project where the guidance documents will be generated.
		/// </summary>
		[Description("A relative path in the project where the guidance documents will be generated.")]
		[DisplayName("Project Content Path")]
		[Category("General")]
		String ProjectContentPath { get; set; }

		/// <summary>
		/// The path to the guidance document
		/// </summary>
		[Description("The path to the guidance document")]
		[DisplayName("Document File Path")]
		[Category("General")]
		String DocumentFilePath { get; set; }

		/// <summary>
		/// The default name of all instances of this guidance.
		/// </summary>
		[Description("The default name of all instances of this guidance.")]
		[DisplayName("Default Instance Name")]
		[Category("General")]
		String DefaultInstanceName { get; set; }

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
		IAssets Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace NuPattern.Authoring.PatternToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.Design;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// The definition of the pattern.
	/// </summary>
	[Description("The definition of the pattern.")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "5da53e5a-0ba8-48f8-a922-1712244c388c", ProxyType = typeof(PatternModel))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface IPatternModel : IToolkitInterface
	{

		/// <summary>
		/// When to validate the pattern model, to ensure that its configuration is valid and up to date.
		/// </summary>
		[Description("When to validate the pattern model, to ensure that its configuration is valid and up to date.")]
		[DisplayName("Validate On Build")]
		[Category("General")]
		[TypeConverter(typeof(ValidateOnBuildConverter))]
		String ValidateOnBuild { get; set; }

		/// <summary>
		/// Path to the definition file.
		/// </summary>
		[Description("Path to the definition file.")]
		[DisplayName("Toolkit Definition File")]
		[Category("General")]
		String ToolkitDefinitionFile { get; set; }

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
		IDevelopment Parent { get; }

		/// <summary>
		/// Gets the <see cref="IViews"/> contained in this element.
		/// </summary>
		IViews Views { get; }

		/// <summary>
		/// Creates a new <see cref="IViews"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		/// </summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IViews CreateViews(string name, Action<IViews> initializer = null, bool raiseInstantiateEvents = true);

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

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
	/// A view or aspect of the pattern.
	/// </summary>
	[Description("A view or aspect of the pattern.")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "6a596dea-529b-4cd5-9eea-7e856a2b332c", ProxyType = typeof(ViewModel))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface IViewModel : IToolkitInterface
	{

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
		IViews Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

namespace NuPattern.Authoring.PatternToolkit
{
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.Design;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// Information for packaging the toolkit as a VSIX extension.
	/// </summary>
	[Description("Information for packaging the toolkit as a VSIX extension.")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "c00ddfa6-b949-4c7c-b8b9-f46b8e3ccf1e", ProxyType = typeof(PatternToolkitInfo))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface IPatternToolkitInfo : IToolkitInterface
	{

		/// <summary>
		/// The name of this pattern toolkit.
		/// </summary>
		[Description("The name of this pattern toolkit.")]
		[DisplayName("Toolkit Name")]
		[Category("Identification")]
		String ToolkitName { get; set; }

		/// <summary>
		/// The original author of this toolkit.
		/// </summary>
		[Description("The original author of this toolkit.")]
		[DisplayName("Author")]
		[Category("Identification")]
		String Author { get; set; }

		/// <summary>
		/// A description of the toolkit.
		/// </summary>
		[Description("A description of the toolkit.")]
		[DisplayName("Toolkit Description")]
		[Category("Identification")]
		String Description { get; set; }

		/// <summary>
		/// The current version of this toolkit.
		/// </summary>
		[Description("The current version of this toolkit.")]
		[DisplayName("Version")]
		[Category("Identification")]
		String Version { get; set; }

		/// <summary>
		/// The unique identifier of this toolkit, also used as the VSIX identifier.
		/// </summary>
		[Description("The unique identifier of this toolkit, also used as the VSIX identifier.")]
		[DisplayName("Identifier")]
		[Category("Identification")]
		String Identifier { get; set; }

		/// <summary>
		/// An optional icon for the toolkit.
		/// </summary>
		[Description("An optional icon for the toolkit.")]
		[DisplayName("Icon")]
		[Category("Identification")]
		[TypeConverter(typeof(ItemRelativePathConverter))]
		[Editor(typeof(IconEditor), typeof(UITypeEditor))]
		String Icon { get; set; }

		/// <summary>
		/// The license terms governing the use and distribution of this toolkit.
		/// </summary>
		[Description("The license terms governing the use and distribution of this toolkit.")]
		[DisplayName("Eula")]
		[Category("Identification")]
		[TypeConverter(typeof(ItemRelativePathConverter))]
		[Editor(typeof(SolutionItemEditor), typeof(UITypeEditor))]
		String Eula { get; set; }

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
		IDevelopment Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}

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
	/// The design of the tooling of the toolkit.
	/// </summary>
	[Description("The design of the tooling of the toolkit.")]
	[ToolkitInterface(ExtensionId = "9f6dc301-6f66-4d21-9f9c-b37412b162f6", DefinitionId = "9291502b-fefc-4ef8-afc0-4c6914f0d2d1", ProxyType = typeof(ProductionTooling))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.22.0")]
	public partial interface IProductionTooling : IToolkitInterface
	{

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
		IDesign Parent { get; }

		/// <summary>
		/// Deletes this element.
		/// </summary>
		void Delete();

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IElement"/>) of this element.
		/// </summary>
		Runtime.IElement AsElement();
	}
}
