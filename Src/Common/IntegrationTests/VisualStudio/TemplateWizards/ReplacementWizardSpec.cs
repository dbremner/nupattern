﻿using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VSSDK.Tools.VsIdeTesting;
using NuPattern.VisualStudio.Solution;

namespace NuPattern.IntegrationTests.TemplateWizards
{
    [TestClass]
    public class ReplacementWizardSpec : IntegrationTest
    {
        internal static readonly IAssertion Assert = new Assertion();

        private ISolution solution;
        private ITemplate toolkitTemplate;

        [TestInitialize]
        public void Initialize()
        {
            this.solution = (ISolution)VsIdeTestHostContext.ServiceProvider.GetService(typeof(ISolution));
            this.solution.CreateInstance(this.DeploymentDirectory, "EmptySolution");

            var templates = (ITemplateService)VsIdeTestHostContext.ServiceProvider.GetService(typeof(ITemplateService));
            this.toolkitTemplate = templates.Find("MyTemplate2", "CSharp");
        }

        [TestCleanup]
        public void Cleanup()
        {
            this.solution.Close(false);
        }

        [TestMethod, TestCategory("Integration")]
        [HostType("VS IDE")]
        public void WhenUnfolding_ThenParameterIsReplaced()
        {
            var project = (IProject)this.toolkitTemplate.Unfold("Foo", this.solution);
            var item = project.Find(@"source.vsixmanifest").First();
            var itemContent = XElement.Load(item.PhysicalPath);

            Assert.Equal("$guid3$", (string)itemContent.Elements().First().Attribute("Id"));
        }
    }
}