using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestGridSplitterExtensions
    {
        [TestMethod]
        public void TestPreviewStyle()
        {
            var cb = GridSplitter();
            var style = Style();

            cb.PreviewStyle(style).PreviewStyle.Should().Be(style);
        }

        [TestMethod]
        public void TestShowsPreview()
        {
            var cb = GridSplitter();

            cb.ShowsPreview(true).ShowsPreview.Should().BeTrue();
        }

        [TestMethod]
        public void TestResizeBehavior()
        {
            var cb = GridSplitter();

            cb.ResizeBehavior(GridResizeBehavior.CurrentAndNext).ResizeBehavior.Should().Be(GridResizeBehavior.CurrentAndNext);
        }

        [TestMethod]
        public void TestResizeDirection()
        {
            var cb = GridSplitter();

            cb.ResizeDirection(GridResizeDirection.Columns).ResizeDirection.Should().Be(GridResizeDirection.Columns);
        }

        [TestMethod]
        public void TestDragIncrement()
        {
            var cb = GridSplitter();

            cb.DragIncrement(42).DragIncrement.Should().Be(42);
        }

        [TestMethod]
        public void TestKeyboardIncrement()
        {
            var cb = GridSplitter();

            cb.KeyboardIncrement(42).KeyboardIncrement.Should().Be(42);
        }
    }
}
