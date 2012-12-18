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
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	The assets used in this toolkit.
	///	</summary>
	[Description("The assets used in this toolkit.")]
	[ToolkitInterface(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "58df3920-65bc-4078-b6a4-ab583f906881", ProxyType = typeof(Assets))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	public partial interface IAssets : IToolkitInterface
	{ 
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		Boolean InTransaction { get;  }
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		Boolean IsSerializing { get;  }
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		String InstanceName { get; set; }
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		Double InstanceOrder { get; set; }
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get;  }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IDevelopment Parent { get; }
		
		/// <summary>
		/// Gets the <see cref="ITemplates"/> contained in this element.
		/// </summary>
		ITemplates Templates { get; }
		
		/// <summary>
		/// Gets the <see cref="IWizards"/> contained in this element.
		/// </summary>
		IWizards Wizards { get; }
		
		/// <summary>
		/// Gets the <see cref="IGuidance"/> contained in this element.
		/// </summary>
		IGuidance Guidance { get; }
		
		/// <summary>
		///	Creates a new <see cref="ITemplates"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		ITemplates CreateTemplates(string name, Action<ITemplates> initializer = null, bool raiseInstantiateEvents = true);
		
		/// <summary>
		///	Creates a new <see cref="IWizards"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IWizards CreateWizards(string name, Action<IWizards> initializer = null, bool raiseInstantiateEvents = true);
		
		/// <summary>
		///	Creates a new <see cref="IGuidance"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IGuidance CreateGuidance(string name, Action<IGuidance> initializer = null, bool raiseInstantiateEvents = true);
		
		///	<summary>
		///	Deletes this element from the store.
		///	</summary>
		void Delete();

		/// <summary>
		/// Gets the generic <see cref="Runtime.ICollection"/> underlying element.
		/// </summary>
		Runtime.ICollection AsCollection();
	}
}

namespace Microsoft.VisualStudio.Patterning.Authoring.Authoring
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	The templates used in this toolkit.
	///	</summary>
	[Description("The templates used in this toolkit.")]
	[ToolkitInterface(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "f53b1915-e5c9-47f0-b33f-64487813d87c", ProxyType = typeof(Templates))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	public partial interface ITemplates : IToolkitInterface
	{ 
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		Boolean InTransaction { get;  }
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		Boolean IsSerializing { get;  }
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		String InstanceName { get; set; }
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		Double InstanceOrder { get; set; }
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get;  }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IAssets Parent { get; }
		
		/// <summary>
		/// Gets the <see cref="IItemTemplates"/> contained in this element.
		/// </summary>
		IItemTemplates ItemTemplates { get; }
		
		/// <summary>
		/// Gets the <see cref="IProjectTemplates"/> contained in this element.
		/// </summary>
		IProjectTemplates ProjectTemplates { get; }
		
		/// <summary>
		/// Gets the <see cref="ITextTemplates"/> contained in this element.
		/// </summary>
		ITextTemplates TextTemplates { get; }
		
		/// <summary>
		///	Creates a new <see cref="IItemTemplates"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IItemTemplates CreateItemTemplates(string name, Action<IItemTemplates> initializer = null, bool raiseInstantiateEvents = true);
		
		/// <summary>
		///	Creates a new <see cref="IProjectTemplates"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IProjectTemplates CreateProjectTemplates(string name, Action<IProjectTemplates> initializer = null, bool raiseInstantiateEvents = true);
		
		/// <summary>
		///	Creates a new <see cref="ITextTemplates"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		ITextTemplates CreateTextTemplates(string name, Action<ITextTemplates> initializer = null, bool raiseInstantiateEvents = true);
		
		///	<summary>
		///	Deletes this element from the store.
		///	</summary>
		void Delete();

		/// <summary>
		/// Gets the generic <see cref="Runtime.ICollection"/> underlying element.
		/// </summary>
		Runtime.ICollection AsCollection();
	}
}

namespace Microsoft.VisualStudio.Patterning.Authoring.Authoring
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	VS item templates
	///	</summary>
	[Description("VS item templates")]
	[ToolkitInterface(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "48591d87-4482-4dae-b5af-3ab807bcd947", ProxyType = typeof(ItemTemplates))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	public partial interface IItemTemplates : IToolkitInterface
	{ 
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		Boolean InTransaction { get;  }
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		Boolean IsSerializing { get;  }
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		String InstanceName { get; set; }
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		Double InstanceOrder { get; set; }
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get;  }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		ITemplates Parent { get; }
		
		/// <summary>
		/// Gets all instances of <see cref="IItemTemplate"/> contained in this element.
		/// </summary>
		IEnumerable<IItemTemplate> ItemTemplate { get; }
		
		/// <summary>
		///	Creates a new <see cref="IItemTemplate"/>  and adds it to the <see cref="ItemTemplate"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IItemTemplate CreateItemTemplate(string name, Action<IItemTemplate> initializer = null, bool raiseInstantiateEvents = true);
		
		///	<summary>
		///	Deletes this element from the store.
		///	</summary>
		void Delete();

		/// <summary>
		/// Gets the generic <see cref="Runtime.ICollection"/> underlying element.
		/// </summary>
		Runtime.ICollection AsCollection();
	}
}

namespace Microsoft.VisualStudio.Patterning.Authoring.Authoring
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	VS project templates.
	///	</summary>
	[Description("VS project templates.")]
	[ToolkitInterface(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "b48e216c-da3e-46db-9fdd-51af29559489", ProxyType = typeof(ProjectTemplates))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	public partial interface IProjectTemplates : IToolkitInterface
	{ 
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		Boolean InTransaction { get;  }
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		Boolean IsSerializing { get;  }
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		String InstanceName { get; set; }
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		Double InstanceOrder { get; set; }
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get;  }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		ITemplates Parent { get; }
		
		/// <summary>
		/// Gets all instances of <see cref="IProjectTemplate"/> contained in this element.
		/// </summary>
		IEnumerable<IProjectTemplate> ProjectTemplate { get; }
		
		/// <summary>
		///	Creates a new <see cref="IProjectTemplate"/>  and adds it to the <see cref="ProjectTemplate"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IProjectTemplate CreateProjectTemplate(string name, Action<IProjectTemplate> initializer = null, bool raiseInstantiateEvents = true);
		
		///	<summary>
		///	Deletes this element from the store.
		///	</summary>
		void Delete();

		/// <summary>
		/// Gets the generic <see cref="Runtime.ICollection"/> underlying element.
		/// </summary>
		Runtime.ICollection AsCollection();
	}
}

namespace Microsoft.VisualStudio.Patterning.Authoring.Authoring
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	T4 code generation templates.
	///	</summary>
	[Description("T4 code generation templates.")]
	[ToolkitInterface(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "81dde21d-392a-4c60-a048-5c5445bf6542", ProxyType = typeof(TextTemplates))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	public partial interface ITextTemplates : IToolkitInterface
	{ 
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		Boolean InTransaction { get;  }
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		Boolean IsSerializing { get;  }
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		String InstanceName { get; set; }
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		Double InstanceOrder { get; set; }
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get;  }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		ITemplates Parent { get; }
		
		/// <summary>
		/// Gets all instances of <see cref="ITextTemplate"/> contained in this element.
		/// </summary>
		IEnumerable<ITextTemplate> TextTemplate { get; }
		
		/// <summary>
		///	Creates a new <see cref="ITextTemplate"/>  and adds it to the <see cref="TextTemplate"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		ITextTemplate CreateTextTemplate(string name, Action<ITextTemplate> initializer = null, bool raiseInstantiateEvents = true);
		
		///	<summary>
		///	Deletes this element from the store.
		///	</summary>
		void Delete();

		/// <summary>
		/// Gets the generic <see cref="Runtime.ICollection"/> underlying element.
		/// </summary>
		Runtime.ICollection AsCollection();
	}
}

namespace Microsoft.VisualStudio.Patterning.Authoring.Authoring
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	Wizards to gather user information
	///	</summary>
	[Description("Wizards to gather user information")]
	[ToolkitInterface(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "e341bc69-c2e1-44ef-811f-6d092497c277", ProxyType = typeof(Wizards))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	public partial interface IWizards : IToolkitInterface
	{ 
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		Boolean InTransaction { get;  }
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		Boolean IsSerializing { get;  }
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		String InstanceName { get; set; }
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		Double InstanceOrder { get; set; }
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get;  }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IAssets Parent { get; }
		
		/// <summary>
		/// Gets all instances of <see cref="IWizard"/> contained in this element.
		/// </summary>
		IEnumerable<IWizard> Wizard { get; }
		
		/// <summary>
		/// Gets the <see cref="IWizardPages"/> contained in this element.
		/// </summary>
		IWizardPages WizardPages { get; }
		
		/// <summary>
		///	Creates a new <see cref="IWizard"/>  and adds it to the <see cref="Wizard"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IWizard CreateWizard(string name, Action<IWizard> initializer = null, bool raiseInstantiateEvents = true);
		
		/// <summary>
		///	Creates a new <see cref="IWizardPages"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IWizardPages CreateWizardPages(string name, Action<IWizardPages> initializer = null, bool raiseInstantiateEvents = true);
		
		///	<summary>
		///	Deletes this element from the store.
		///	</summary>
		void Delete();

		/// <summary>
		/// Gets the generic <see cref="Runtime.ICollection"/> underlying element.
		/// </summary>
		Runtime.ICollection AsCollection();
	}
}

namespace Microsoft.VisualStudio.Patterning.Authoring.Authoring
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	The pages of the wizard
	///	</summary>
	[Description("The pages of the wizard")]
	[ToolkitInterface(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "3906075a-6263-4e5d-be94-3750e6fc1e57", ProxyType = typeof(WizardPages))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	public partial interface IWizardPages : IToolkitInterface
	{ 
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		Boolean InTransaction { get;  }
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		Boolean IsSerializing { get;  }
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		String InstanceName { get; set; }
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		Double InstanceOrder { get; set; }
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get;  }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IWizards Parent { get; }
		
		/// <summary>
		/// Gets all instances of <see cref="IWizardPage"/> contained in this element.
		/// </summary>
		IEnumerable<IWizardPage> WizardPage { get; }
		
		/// <summary>
		///	Creates a new <see cref="IWizardPage"/>  and adds it to the <see cref="WizardPage"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IWizardPage CreateWizardPage(string name, Action<IWizardPage> initializer = null, bool raiseInstantiateEvents = true);
		
		///	<summary>
		///	Deletes this element from the store.
		///	</summary>
		void Delete();

		/// <summary>
		/// Gets the generic <see cref="Runtime.ICollection"/> underlying element.
		/// </summary>
		Runtime.ICollection AsCollection();
	}
}

namespace Microsoft.VisualStudio.Patterning.Authoring.Authoring
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	Automation for the pattern model.
	///	</summary>
	[Description("Automation for the pattern model.")]
	[ToolkitInterface(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "994965b7-d2b1-4460-8947-44ca73227b5f", ProxyType = typeof(AutomationCollection))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	public partial interface IAutomationCollection : IToolkitInterface
	{ 
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		Boolean InTransaction { get;  }
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		Boolean IsSerializing { get;  }
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		String InstanceName { get; set; }
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		Double InstanceOrder { get; set; }
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get;  }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IDevelopment Parent { get; }
		
		/// <summary>
		/// Gets the <see cref="IAutomationLibrary"/> contained in this element.
		/// </summary>
		IAutomationLibrary AutomationLibrary { get; }
		
		/// <summary>
		///	Creates a new <see cref="IAutomationLibrary"/>  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IAutomationLibrary CreateAutomationLibrary(string name, Guid productId, string toolkitId, Action<IAutomationLibrary> initializer = null, bool raiseInstantiateEvents = true);
		
		///	<summary>
		///	Deletes this element from the store.
		///	</summary>
		void Delete();

		/// <summary>
		/// Gets the generic <see cref="Runtime.ICollection"/> underlying element.
		/// </summary>
		Runtime.ICollection AsCollection();
	}
}

namespace Microsoft.VisualStudio.Patterning.Authoring.Authoring
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	The views (or aspects) being modeled in the pattern.
	///	</summary>
	[Description("The views (or aspects) being modeled in the pattern.")]
	[ToolkitInterface(ExtensionId ="84031a32-b20f-479c-a620-beacd982ea13", DefinitionId = "739aef21-5f1e-421b-804a-47f11f93c9c3", ProxyType = typeof(Views))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.3.20.0")]
	public partial interface IViews : IToolkitInterface
	{ 
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		String Notes { get; set; }
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		Boolean InTransaction { get;  }
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		Boolean IsSerializing { get;  }
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		String InstanceName { get; set; }
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		Double InstanceOrder { get; set; }
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		IEnumerable<IReference> References { get;  }

		/// <summary>
		/// Gets the parent element.
		/// </summary>
		IPatternModel Parent { get; }
		
		/// <summary>
		/// Gets all instances of <see cref="IViewModel"/> contained in this element.
		/// </summary>
		IEnumerable<IViewModel> ViewModels { get; }
		
		/// <summary>
		///	Creates a new <see cref="IViewModel"/>  and adds it to the <see cref="ViewModels"/> collection,  
		/// executing the optional <paramref name="initializer"/> if not <see langword="null"/>.
		///	</summary>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed")]
		IViewModel CreateViewModel(string name, Action<IViewModel> initializer = null, bool raiseInstantiateEvents = true);
		
		///	<summary>
		///	Deletes this element from the store.
		///	</summary>
		void Delete();

		/// <summary>
		/// Gets the generic <see cref="Runtime.ICollection"/> underlying element.
		/// </summary>
		Runtime.ICollection AsCollection();
	}
}

