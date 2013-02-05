﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuPattern.Authoring.PatternToolkitLibrary
{
	using global::NuPattern.Extensibility;
	using global::NuPattern.Runtime;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Composition;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::NuPattern.Runtime;

	///	<summary>
	///	A library that contains reusable automation types for sharing between Pattern Toolkit projects.
	///	</summary>
	[Description("A library that contains reusable automation types for sharing between Pattern Toolkit projects.")]
	[ToolkitInterfaceProxy(ExtensionId ="97bd7ab2-964b-43f1-8a08-be6db68b018b", DefinitionId = "d6139b37-9971-4834-a9dc-2b3daef962cf", ProxyType = typeof(PatternToolkitLibrary))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.20.0")]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	internal partial class PatternToolkitLibrary : IPatternToolkitLibrary
	{
		private Runtime.IProduct target;
		private Runtime.IProductProxy<IPatternToolkitLibrary> proxy;

		/// <summary>
		/// For MEF.
		/// </summary>
		[ImportingConstructor]
		private PatternToolkitLibrary() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="PatternToolkitLibrary"/> class.
		/// </summary>
		public PatternToolkitLibrary(Runtime.IProduct target)
		{
			this.target = target;
			this.proxy = target.ProxyFor<IPatternToolkitLibrary>();
			OnCreated();
		}	

		partial void OnCreated();

		///	<summary>
		///	When to transform all code generation templates in this library, to ensure that all library artifacts are up to date.
		///	</summary>
		[Description("When to transform all code generation templates in this library, to ensure that all library artifacts are up to date.")]
		[DisplayName("Transform On Build")]
		[Category("Code Generation")]
		[TypeConverter(typeof(TransformOnBuildConverter))]
		public virtual String TransformOnBuild 
		{
			get { return this.proxy.GetValue(() => this.TransformOnBuild); }
			set { this.proxy.SetValue(() => this.TransformOnBuild, value); }
		}

		///	<summary>
		///	The project root namespace
		///	</summary>
		[Description("The project root namespace")]
		[DisplayName("Toolkit Project Root Namespace")]
		[Category("General")]
		public virtual String ToolkitProjectRootNamespace 
		{
			get { return this.proxy.GetValue(() => this.ToolkitProjectRootNamespace); }
			set { this.proxy.SetValue(() => this.ToolkitProjectRootNamespace, value); }
		}

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
		///	The name of the automation library project.
		///	</summary>
		[Description("The name of the automation library project.")]
		[DisplayName("Project Name")]
		[Category("General")]
		public virtual String ProjectName 
		{
			get { return this.proxy.GetValue(() => this.ProjectName); }
			set { this.proxy.SetValue(() => this.ProjectName, value); }
		}

		///	<summary>
		///	Excludes all generated code from code coverage metrics.
		///	</summary>
		[Description("Excludes all generated code from code coverage metrics.")]
		[DisplayName("Exclude From Code Coverage")]
		[Category("Code Generation")]
		public virtual Boolean ExcludeFromCodeCoverage 
		{
			get { return this.proxy.GetValue(() => this.ExcludeFromCodeCoverage); }
			set { this.proxy.SetValue(() => this.ExcludeFromCodeCoverage, value); }
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
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
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
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		[Description("Notes for this element.")]
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

		///	<summary>
		///	Description for PatternToolkitLibrary.Development
		///	</summary>
		[Description("Description for PatternToolkitLibrary.Development")]
		public virtual IDevelopment Development
		{ 
			get { return this.proxy.GetView(() => this.Development, view => new Development(view)); }
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