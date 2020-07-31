using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestSetters
    {
        [TestMethod]
        public void TestSnapsToPixels()
        {
            var setter = Setters.SnapsToPixels(true);

            setter.Property.Should().Be(UIElement.SnapsToDevicePixelsProperty);
            setter.Value.Should().Be(true);
        }

        [TestMethod]
        public void TestBackground()
        {
            var setter = Setters.Background(Brushes.Red);

            setter.Property.Should().Be(Control.BackgroundProperty);
            setter.Value.Should().Be(Brushes.Red);
        }

        [TestMethod]
        public void TestFontSize()
        {
            var setter = Setters.FontSize(20);

            setter.Property.Should().Be(Control.FontSizeProperty);
            setter.Value.Should().Be(20);
        }

        [TestMethod]
        public void TestBorderBrush()
        {
            var setter = Setters.BorderBrush(Brushes.Yellow);

            setter.Property.Should().Be(Control.BorderBrushProperty);
            setter.Value.Should().Be(Brushes.Yellow);
        }

        [TestMethod]
        public void TestBorderThickness()
        {
            var setter = Setters.BorderThickness(2);

            setter.Property.Should().Be(Control.BorderThicknessProperty);
            setter.Value.Should().BeEquivalentTo(new Thickness(2));
        }

        [TestMethod]
        public void TestFontFamily()
        {
            var setter = Setters.FontFamily("Arial");

            setter.Property.Should().Be(Control.FontFamilyProperty);
            setter.Value.Should().BeEquivalentTo(new FontFamily("Arial"));
        }

        [TestMethod]
        public void TestFontWeight()
        {
            var setter = Setters.FontWeight(FontWeights.Bold);

            setter.Property.Should().Be(Control.FontWeightProperty);
            setter.Value.Should().Be(FontWeights.Bold);
        }

        [TestMethod]
        public void TestFontStyle()
        {
            var setter = Setters.FontStyle(FontStyles.Italic);

            setter.Property.Should().Be(Control.FontStyleProperty);
            setter.Value.Should().Be(FontStyles.Italic);
        }
    }
}
