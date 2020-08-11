using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestVirtualizingStackPanelExtensions
    {
        [TestMethod]
        public void TestOrientation()
        {
            var panel = VirtStackPanel();

            panel.Orientation(Orientation.Horizontal).Orientation.Should().Be(Orientation.Horizontal);
        }

        [TestMethod]
        public void TestScrollOwner()
        {
            var panel = VirtStackPanel();
            var scrollViewer = new ScrollViewer();

            panel.ScrollOwner(scrollViewer).ScrollOwner.Should().Be(scrollViewer);
        }
    }
}
