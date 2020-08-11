using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestWrapPanelExtensions
    {
        [TestMethod]
        public void TestOrientation()
        {
            var panel = WrapPanel();

            panel.Orientation(Orientation.Horizontal).Orientation.Should().Be(Orientation.Horizontal);
        }

        [TestMethod]
        public void TestItemWidth()
        {
            var panel = WrapPanel();

            panel.ItemWidth(125).ItemWidth.Should().Be(125);
        }

        [TestMethod]
        public void TestItemHeight()
        {
            var panel = WrapPanel();

            panel.ItemHeight(42).ItemHeight.Should().Be(42);
        }
    }
}
