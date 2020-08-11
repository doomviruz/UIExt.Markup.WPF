using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestScrollViewerExtensions
    {
        [TestMethod]
        public void TestLastChildFill()
        {
            var cb = ScrollViewer();

            cb.CanContentScroll(true).CanContentScroll.Should().BeTrue();
        }

        [TestMethod]
        public void TestHorizontalScrollBarVisibility()
        {
            var cb = ScrollViewer();

            cb.HorizontalScrollBarVisibility(ScrollBarVisibility.Disabled).HorizontalScrollBarVisibility.Should().Be(ScrollBarVisibility.Disabled);
        }

        [TestMethod]
        public void TestVerticalScrollBarVisibility()
        {
            var cb = ScrollViewer();

            cb.VerticalScrollBarVisibility(ScrollBarVisibility.Disabled).VerticalScrollBarVisibility.Should().Be(ScrollBarVisibility.Disabled);
        }

        [TestMethod]
        public void TestPanningDeceleration()
        {
            var cb = ScrollViewer();

            cb.PanningDeceleration(42).PanningDeceleration.Should().Be(42);
        }

        [TestMethod]
        public void TestIsDeferredScrollingEnabled()
        {
            var cb = ScrollViewer();

            cb.IsDeferredScrollingEnabled(true).IsDeferredScrollingEnabled.Should().BeTrue();
        }

        [TestMethod]
        public void TestPanningMode()
        {
            var cb = ScrollViewer();

            cb.PanningMode(PanningMode.HorizontalOnly).PanningMode.Should().Be(PanningMode.HorizontalOnly);
        }

        [TestMethod]
        public void TestPanningRatio()
        {
            var cb = ScrollViewer();

            cb.PanningRatio(42).PanningRatio.Should().Be(42);
        }

    }
}
