using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestNavigationWindowExtensions
    {
        [TestMethod]
        public void TestTargetName()
        {
            var wnd = NavigationWindow();

            wnd.SandboxExternalContent(true).SandboxExternalContent.Should().Be(true);
        }
    }
}
