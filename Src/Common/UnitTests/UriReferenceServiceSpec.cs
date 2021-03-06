﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace NuPattern.UnitTests
{
    [TestClass]
    public class UriReferenceServiceSpec
    {
        internal static readonly IAssertion Assert = new Assertion();

        [TestMethod, TestCategory("Unit")]
        public void WhenMultipleProvidersPerScheme_ThenSelectsAppropriateOneForResolving()
        {
            var foo = Mock.Of<IFoo>();
            var bar = Mock.Of<IBar>();

            var fooProvider = Mock.Of<IUriReferenceProvider<IFoo>>(p => p.UriScheme == "mock" && p.ResolveUri(It.IsAny<Uri>()) == foo);
            var barProvider = Mock.Of<IUriReferenceProvider<IBar>>(p => p.UriScheme == "mock" && p.ResolveUri(It.IsAny<Uri>()) == bar);

            var uriService = new UriReferenceService(new IUriReferenceProvider[] { fooProvider, barProvider });

            var fooValue = uriService.ResolveUri<IFoo>(new Uri("mock://kzu"));
            var barValue = uriService.ResolveUri<IBar>(new Uri("mock://kzu"));

            Assert.Same(foo, fooValue);
            Assert.Same(bar, barValue);
        }

        // TODO: still failing on FB 1.0
        [Ignore]
        [TestMethod, TestCategory("Unit")]
        public void WhenSingleProviderProvidesMultipleResolvedTypes_ThenThrowsNotSupportedException()
        {
            var foo = Mock.Of<IDerivedFoo>();
            var bar = Mock.Of<IBar>();

            var fooProvider = new Mock<IUriReferenceProvider<IFoo>>();
            fooProvider.Setup(p => p.UriScheme).Returns("mock");
            fooProvider.Setup(p => p.ResolveUri(It.IsAny<Uri>())).Returns(foo);

            fooProvider.As<IUriReferenceProvider<IDerivedFoo>>()
                .Setup(x => x.ResolveUri(It.IsAny<Uri>()))
                .Returns(foo);

            var barProvider = Mock.Of<IUriReferenceProvider<IBar>>(p => p.UriScheme == "mock" && p.ResolveUri(It.IsAny<Uri>()) == bar);

            var uriService = new UriReferenceService(new IUriReferenceProvider[] { fooProvider.Object, barProvider });

            var fooValue = uriService.ResolveUri<IFoo>(new Uri("mock://kzu"));
            var bazValue = uriService.ResolveUri<IDerivedFoo>(new Uri("mock://kzu"));

            Assert.Same(fooValue, bazValue);
        }

        // TODO: still failing on FB 1.0
        [Ignore]
        [TestMethod, TestCategory("Unit")]
        public void WhenMultipleProvidersPerSchemeForRelatedTypes_ThenSelectsAppropriateOneForResolving()
        {
            var derived = Mock.Of<IDerivedFoo>();

            var fooProvider = Mock.Of<IUriReferenceProvider<IFoo>>(p => p.UriScheme == "mock" && p.ResolveUri(It.IsAny<Uri>()) == derived);
            var deriveProvider = Mock.Of<IUriReferenceProvider<IDerivedFoo>>(p => p.UriScheme == "mock" && p.ResolveUri(It.IsAny<Uri>()) == derived);

            var uriService = new UriReferenceService(new IUriReferenceProvider[] { fooProvider, deriveProvider });

            var fooValue = uriService.ResolveUri<IFoo>(new Uri("mock://kzu"));
            var derivedValue = uriService.ResolveUri<IDerivedFoo>(new Uri("mock://kzu"));

            Assert.Same(derived, fooValue);
            Assert.Same(derived, derivedValue);
        }

        public interface IFoo { }
        public interface IBar { }

        public interface IDerivedFoo : IFoo { }
    }
}
