﻿using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NuPattern.Runtime.Bindings;
using NuPattern.Runtime.Bindings.Design;

namespace NuPattern.Runtime.UnitTests.Binding.Design
{
    public class DesignPropertyValueProviderDescriptorSpec
    {
        private static readonly IAssertion Assert = new Assertion();

        [TestClass]
        public class GivenAStringDesignProperty
        {
            private DesignPropertyValueProviderDescriptor descriptor;
            private DesignProperty component;
            private Mock<IPropertyBindingSettings> settings;

            [TestInitialize]
            public void InitializeContext()
            {
                this.settings = new Mock<IPropertyBindingSettings>();
                this.component = new DesignProperty(this.settings.Object);
                this.component.Attributes = new Attribute[0];
                this.component.Type = typeof(string);

                var innerDescriptor = new Mock<PropertyDescriptor>("foo", new Attribute[0]);
                innerDescriptor.Setup(x => x.Name).Returns("Property");
                innerDescriptor.Setup(x => x.Attributes).Returns(new AttributeCollection());
                this.descriptor = new DesignPropertyValueProviderDescriptor(innerDescriptor.Object);
            }

            [TestMethod, TestCategory("Unit")]
            public void WhenValueProviderIsNull_ThenCanResetValueIsFalse()
            {
                this.settings.Setup(s => s.ValueProvider).Returns((IValueProviderBindingSettings)null);

                Assert.False(this.descriptor.CanResetValue(this.component));
            }

            [TestMethod, TestCategory("Unit")]
            public void WhenHasAValueProvider_ThenCanResetValueIsTrue()
            {
                this.settings.Setup(s => s.ValueProvider).Returns(Mock.Of<IValueProviderBindingSettings>());

                Assert.True(this.descriptor.CanResetValue(this.component));
            }

            [TestMethod, TestCategory("Unit")]
            public void WhenReset_ThenValueProviderIsNull()
            {
                this.settings.Setup(s => s.ValueProvider).Returns(Mock.Of<IValueProviderBindingSettings>());
                this.descriptor.ResetValue(this.component);

                this.settings.VerifySet(s => s.ValueProvider = null);
            }
        }
    }
}
