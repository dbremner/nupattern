﻿using System;
using Microsoft.VSSDK.Tools.VsIdeTesting;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Modeling.Shell;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VsSDK.IntegrationTestLibrary;

namespace Microsoft.VisualStudio.Patterning.Common.IntegrationTests
{
	[TestClass]
	public class Misc
	{
		internal static readonly IAssertion Assert = new Assertion();

		[HostType("VS IDE")]
		[TestMethod]
		public void WhenGettingServiceProviderFromPackage_ThenSucceeds()
		{
			var components = (IComponentModel)Package.GetGlobalService(typeof(SComponentModel));
			var service = (IServiceProvider)components.GetService<SVsServiceProvider>();

			Assert.NotNull(service);
		}

		[HostType("VS IDE")]
		[TestMethod]
		[Ignore]
		public void WhenShowingMessage_ThenSucceeds()
		{
			var components = (IComponentModel)Package.GetGlobalService(typeof(SComponentModel));
			var service = (IServiceProvider)components.GetService<SVsServiceProvider>();
			var ui = (IVsUIShell)service.GetService(typeof(SVsUIShell));

			Assert.NotNull(service);
			Assert.NotNull(ui);

			using (var purger = new DialogBoxPurger(0))
			{
				UIThreadInvoker.Invoke((Action)(() =>
				{
					PackageUtility.ShowError(service, "Foo", string.Empty);
				}));
			}
		}
	}
}
