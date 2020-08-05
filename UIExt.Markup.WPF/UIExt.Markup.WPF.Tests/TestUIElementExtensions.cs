using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestUIElementExtensions
    {
        [TestMethod]
        public void TestSetRow()
        {
            var element = Button();

            element.Row(2);

            System.Windows.Controls.Grid.GetRow(element).Should().Be(2);
        }

        [TestMethod]
        public void TestSetColumn()
        {
            var element = Button();

            element.Column(2);

            System.Windows.Controls.Grid.GetColumn(element).Should().Be(2);
        }

        [TestMethod]
        public void TestSetRowSpan()
        {
            var element = Button();

            element.RowSpan(2);

            System.Windows.Controls.Grid.GetRowSpan(element).Should().Be(2);
        }

        [TestMethod]
        public void TestSetColumnSpan()
        {
            var element = Button();

            element.ColumnSpan(2);

            System.Windows.Controls.Grid.GetColumnSpan(element).Should().Be(2);
        }

        [TestMethod]
        public void TestSetCanvasLeft()
        {
            var element = Button();

            element.CanvasLeft(111);

            System.Windows.Controls.Canvas.GetLeft(element).Should().Be(111);
        }

        [TestMethod]
        public void TestSetCanvasTop()
        {
            var element = Button();

            element.CanvasTop(111);

            System.Windows.Controls.Canvas.GetTop(element).Should().Be(111);
        }

        [TestMethod]
        public void TestSetCanvasRight()
        {
            var element = Button();

            element.CanvasRight(111);

            System.Windows.Controls.Canvas.GetRight(element).Should().Be(111);
        }

        [TestMethod]
        public void TestSetCanvasBottom()
        {
            var element = Button();

            element.CanvasBottom(111);

            System.Windows.Controls.Canvas.GetBottom(element).Should().Be(111);
        }

        [TestMethod]
        public void TestAllowDrop()
        {
            var element = Button();

            element.AllowDrop(true).AllowDrop.Should().BeTrue();
        }

        [TestMethod]
        public void TestRenderSize()
        {
            var element = Button();

            element.RenderSize(new Size(100, 150)).RenderSize.Should().BeEquivalentTo(new Size(100, 150));
        }

        [TestMethod]
        public void TestRenderTransform()
        {
            var element = Button();
            var transform = new RotateTransform();

            element.RenderTransform(transform).RenderTransform.Should().Be(transform);
        }

        [TestMethod]
        public void TestRenderTransformOrigin()
        {
            var element = Button();

            element.RenderTransformOrigin(new Point(20, 20)).RenderTransformOrigin.Should().BeEquivalentTo(new Point(20, 20));
        }

        [TestMethod]
        public void TestOpacity()
        {
            var element = Button();

            element.Opacity(0.5).Opacity.Should().Be(0.5);
        }

        [TestMethod]
        public void TestOpacityMask()
        {
            var element = Button();

            element.OpacityMask(Brushes.Red).OpacityMask.Should().Be(Brushes.Red);
        }

        [TestMethod]
        public void TestEffect()
        {
            var element = Button();
            var effect = new BlurEffect();

            element.Effect(effect).Effect.Should().Be(effect);
        }

        [TestMethod]
        public void TestCacheMode()
        {
            var element = Button();
            var cache = new BitmapCache();

            element.CacheMode(cache).CacheMode.Should().Be(cache);
        }

        [TestMethod]
        public void TestUid()
        {
            var element = Button();
            var uid = Guid.NewGuid().ToString();

            element.Uid(uid).Uid.Should().Be(uid);
        }

        [TestMethod]
        public void TestVisibility()
        {
            var element = Button();

            element.Visibility(Visibility.Hidden).Visibility.Should().Be(Visibility.Hidden);
            element.Visibile().Visibility.Should().Be(Visibility.Visible);
            element.Collapsed().Visibility.Should().Be(Visibility.Collapsed);
            element.Hidden().Visibility.Should().Be(Visibility.Hidden);
        }

        [TestMethod]
        public void TestClipToBounds()
        {
            var element = Button();

            element.ClipToBounds(true).ClipToBounds.Should().BeTrue();
        }

        [TestMethod]
        public void TestClip()
        {
            var element = Button();
            var clip = new RectangleGeometry();

            element.Clip(clip).Clip.Should().Be(clip);
        }

        [TestMethod]
        public void TestSnapsToDevicePixels()
        {
            var element = Button();

            element.SnapsToDevicePixels(true).SnapsToDevicePixels.Should().BeTrue();
        }

        [TestMethod]
        public void TestIsEnabled()
        {
            var element = Button();

            element.IsEnabled(false).IsEnabled.Should().BeFalse();
        }

        [TestMethod]
        public void TestIsHitTestVisible()
        {
            var element = Button();

            element.IsHitTestVisible(false).IsHitTestVisible.Should().BeFalse();
        }

        [TestMethod]
        public void TestFocusable()
        {
            var element = Button();

            element.Focusable(false).Focusable.Should().BeFalse();
        }

        [TestMethod]
        public void TestIsManipulationEnabled()
        {
            var element = Button();

            element.IsManipulationEnabled(false).IsManipulationEnabled.Should().BeFalse();
        }
    }
}
