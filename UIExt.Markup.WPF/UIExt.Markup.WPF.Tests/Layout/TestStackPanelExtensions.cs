using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestStackPanelExtensions
    {
        [TestMethod]
        public void TestOrientation()
        {
            var panel = StackPanel();

            panel.Orientation(Orientation.Horizontal).Orientation.Should().Be(Orientation.Horizontal);
        }

        [TestMethod]
        public void TestScrollOwner()
        {
            var panel = StackPanel();
            var scrollViewer = new ScrollViewer();

            panel.ScrollOwner(scrollViewer).ScrollOwner.Should().Be(scrollViewer);
        }
    }
}
