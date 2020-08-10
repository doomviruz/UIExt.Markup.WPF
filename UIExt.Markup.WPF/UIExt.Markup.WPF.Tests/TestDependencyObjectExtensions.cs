using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestDependencyObjectExtensions
    {
        [TestMethod]
        public void TestCanContentScroll()
        {
            var cb = CheckBox();

            cb.CanContentScroll(true);

            System.Windows.Controls.ScrollViewer.GetCanContentScroll(cb).Should().Be(true);
        }

        [TestMethod]
        public void TestHorizontalScrollBarVisibility()
        {
            var cb = CheckBox();

            cb.HorizontalScrollBarVisibility(ScrollBarVisibility.Disabled);

            System.Windows.Controls.ScrollViewer.GetHorizontalScrollBarVisibility(cb).Should().Be(ScrollBarVisibility.Disabled);
        }

        [TestMethod]
        public void TestVerticalScrollBarVisibility()
        {
            var cb = Canvas();

            cb.VerticalScrollBarVisibility(ScrollBarVisibility.Disabled);

            System.Windows.Controls.ScrollViewer.GetVerticalScrollBarVisibility(cb).Should().Be(ScrollBarVisibility.Disabled);
        }

        [TestMethod]
        public void TestIsDeferredScrollingEnabled()
        {
            var cb = CheckBox();

            cb.IsDeferredScrollingEnabled(true);

            System.Windows.Controls.ScrollViewer.GetIsDeferredScrollingEnabled(cb).Should().Be(true);
        }

        [TestMethod]
        public void TestPanningDeceleration()
        {
            var cb = ResizeGrip();

            cb.PanningDeceleration(42);

            System.Windows.Controls.ScrollViewer.GetPanningDeceleration(cb).Should().Be(42);
        }

        [TestMethod]
        public void TestPanningMode()
        {
            var cb = Separator();

            cb.PanningMode(PanningMode.HorizontalOnly);

            System.Windows.Controls.ScrollViewer.GetPanningMode(cb).Should().Be(PanningMode.HorizontalOnly);
        }

        [TestMethod]
        public void TestPanningRatio()
        {
            var cb = CheckBox();

            cb.PanningRatio(42);

            System.Windows.Controls.ScrollViewer.GetPanningRatio(cb).Should().Be(42);
        }

        [TestMethod]
        public void TestOverflowMode()
        {
            var cb = CheckBox();

            cb.OverflowMode(OverflowMode.Never);

            System.Windows.Controls.ToolBar.GetOverflowMode(cb).Should().Be(OverflowMode.Never);
        }
    }
}
