using System.Threading.Tasks;
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

        [TestMethod]
        public void TestSetIsSelected()
        {
            var lb = ListBox();

            lb.SetIsSelected(true);

            System.Windows.Controls.Primitives.Selector.GetIsSelected(lb).Should().Be(true);
        }

        [TestMethod]
        public void TestAddSelectedHandler()
        {
            var fired = false;
            var item = new ListBoxItem();
            RoutedEventHandler handler = (_, e) => 
            {
                fired = true;
            };

            item.AddSelectedHandler(handler);
            item.SetIsSelected(true);

            fired.Should().Be(true);
        }

        [TestMethod]
        public void TestRemoveSelectedHandler()
        {
            var fired = false;
            var item = new ListBoxItem();
            RoutedEventHandler handler = (_, e) =>
            {
                fired = true;
            };

            item.AddSelectedHandler(handler);
            item.SetIsSelected(true);

            fired.Should().Be(true);

            item.SetIsSelected(false);
            fired = false;

            item.RemoveSelectedHandler(handler);
            item.SetIsSelected(true);

            fired.Should().Be(false);
        }

        [TestMethod]
        public void TestAddUnselectedHandler()
        {
            var fired = false;
            var item = new ListBoxItem();
            RoutedEventHandler handler = (_, e) =>
            {
                fired = true;
            };

            item.SetIsSelected(true);
            item.AddUnselectedHandler(handler);
            item.SetIsSelected(false);

            fired.Should().Be(true);
        }

        [TestMethod]
        public void TestRemoveUnSelectedHandler()
        {
            var fired = false;
            var item = new ListBoxItem();
            RoutedEventHandler handler = (_, e) =>
            {
                fired = true;
            };

            item.SetIsSelected(true);
            item.AddUnselectedHandler(handler);
            item.SetIsSelected(false);

            fired.Should().Be(true);

            item.SetIsSelected(true);
            fired = false;

            item.RemoveUnselectedHandler(handler);
            item.SetIsSelected(false);

            fired.Should().Be(false);
        }
    }
}
