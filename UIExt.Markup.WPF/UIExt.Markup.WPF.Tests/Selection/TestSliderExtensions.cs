using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestSliderExtensions
    {
        [TestMethod]
        public void TestIsSnapToTickEnabled()
        {
            var element = Slider();

            element.IsSnapToTickEnabled(true).IsSnapToTickEnabled.Should().Be(true);
        }

        [TestMethod]
        public void TestAutoToolTipPrecision()
        {
            var element = Slider();

            element.AutoToolTipPrecision(42).AutoToolTipPrecision.Should().Be(42);
        }

        [TestMethod]
        public void TestAutoToolTipPlacement()
        {
            var element = Slider();

            element.AutoToolTipPlacement(AutoToolTipPlacement.TopLeft).AutoToolTipPlacement.Should().Be(AutoToolTipPlacement.TopLeft);
        }

        [TestMethod]
        public void TestInterval()
        {
            var element = Slider();

            element.Interval(42).Interval.Should().Be(42);
        }

        [TestMethod]
        public void TestDelay()
        {
            var element = Slider();

            element.Delay(42).Delay.Should().Be(42);
        }

        [TestMethod]
        public void TestIsDirectionReversed()
        {
            var element = Slider();

            element.IsDirectionReversed(true).IsDirectionReversed.Should().Be(true);
        }

        [TestMethod]
        public void TestOrientation()
        {
            var element = Slider();

            element.Orientation(Orientation.Vertical).Orientation.Should().Be(Orientation.Vertical);
        }

        [TestMethod]
        public void TestTickFrequency()
        {
            var element = Slider();

            element.TickFrequency(42).TickFrequency.Should().Be(42);
        }

        [TestMethod]
        public void TestTicks()
        {
            var element = Slider();
            var ticks = new DoubleCollection();

            element.Ticks(ticks).Ticks.Should().BeSameAs(ticks);
        }

        [TestMethod]
        public void TestSelectionStart()
        {
            var element = Slider();

            element.Minimum(0).Maximum(100);
            element.SelectionStart(42).SelectionStart.Should().Be(42);
        }

        [TestMethod]
        public void TestTickPlacement()
        {
            var element = Slider();

            element.TickPlacement(TickPlacement.BottomRight).TickPlacement.Should().Be(TickPlacement.BottomRight);
        }

        [TestMethod]
        public void TestIsSelectionRangeEnabled()
        {
            var element = Slider();

            element.IsSelectionRangeEnabled(true).IsSelectionRangeEnabled.Should().Be(true);
        }

        [TestMethod]
        public void TestIsMoveToPointEnabled()
        {
            var element = Slider();

            element.IsMoveToPointEnabled(true).IsMoveToPointEnabled.Should().Be(true);
        }

        [TestMethod]
        public void TestSelectionEnd()
        {
            var element = Slider();

            element.Minimum(0).Maximum(100);
            element.SelectionEnd(42).SelectionEnd.Should().Be(42);
        }
    }
}
