using System.Windows;
using System.Windows.Controls.Primitives;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestContextMenuExtensions
    {
        [TestMethod]
        public void TestHorizontalOffset()
        {
            var menu = ContextMenu();

            menu.HorizontalOffset(42).HorizontalOffset.Should().Be(42);
        }

        [TestMethod]
        public void TestStaysOpen()
        {
            var menu = ContextMenu();

            menu.StaysOpen(true).StaysOpen.Should().Be(true);
        }

        [TestMethod]
        public void TestCustomPopupPlacementCallback()
        {
            var menu = ContextMenu();
            CustomPopupPlacementCallback callback = (Size size, Size targetSize, Point offset) => new CustomPopupPlacement[] { };

            menu.PlacementCallback(callback).CustomPopupPlacementCallback.Should().Be(callback);
        }

        [TestMethod]
        public void TestHasDropShadow()
        {
            var menu = ContextMenu();

            menu.HasDropShadow(false).HasDropShadow.Should().Be(false);
        }

        [TestMethod]
        public void TestPlacement()
        {
            var menu = ContextMenu();

            menu.Placement(PlacementMode.Relative).Placement.Should().Be(PlacementMode.Relative);
        }

        [TestMethod]
        public void TestPlacementRectangle()
        {
            var menu = ContextMenu();
            var rect = new Rect();

            menu.PlacementRectangle(rect).PlacementRectangle.Should().BeEquivalentTo(rect);
        }

        [TestMethod]
        public void TestPlacementTarget()
        {
            var menu = ContextMenu();
            var element = Button();

            menu.PlacementTarget(element).PlacementTarget.Should().Be(element);
        }

        [TestMethod]
        public void TestIsOpen()
        {
            var menu = ContextMenu();

            menu.IsOpen(true).IsOpen.Should().Be(true);
        }

        [TestMethod]
        public void TestVerticalOffset()
        {
            var menu = ContextMenu();

            menu.VerticalOffset(42).VerticalOffset.Should().Be(42);
        }
    }
}
