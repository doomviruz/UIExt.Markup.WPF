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
        public void TestForeground()
        {
            var setter = Setters.Foreground(Brushes.Red);

            setter.Property.Should().Be(Control.ForegroundProperty);
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

        [TestMethod]
        public void TestFontStretch()
        {
            var setter = Setters.FontStretch(FontStretches.Expanded);

            setter.Property.Should().Be(Control.FontStretchProperty);
            setter.Value.Should().Be(FontStretches.Expanded);
        }

        [TestMethod]
        public void TestHContentAlign()
        {
            var setter = Setters.HContentAlign(HorizontalAlignment.Right);

            setter.Property.Should().Be(Control.HorizontalContentAlignmentProperty);
            setter.Value.Should().Be(HorizontalAlignment.Right);
        }

        [TestMethod]
        public void TestVContentAlign()
        {
            var setter = Setters.VContentAlign(VerticalAlignment.Bottom);

            setter.Property.Should().Be(Control.VerticalContentAlignmentProperty);
            setter.Value.Should().Be(VerticalAlignment.Bottom);
        }

        [TestMethod]
        public void TestIsTabStop()
        {
            var setter = Setters.IsTabStop(false);

            setter.Property.Should().Be(Control.IsTabStopProperty);
            setter.Value.Should().Be(false);
        }

        [TestMethod]
        public void TestTabIndex()
        {
            var setter = Setters.TabIndex(5);

            setter.Property.Should().Be(Control.TabIndexProperty);
            setter.Value.Should().Be(5);
        }

        [TestMethod]
        public void TestTemplate()
        {
            var template = new ControlTemplate(typeof(Button));
            var setter = Setters.Template(template);

            setter.Property.Should().Be(Control.TemplateProperty);
            setter.Value.Should().Be(template);
        }

        [TestMethod]
        public void TestPadding()
        {
            var setter = Setters.Padding(2);

            setter.Property.Should().Be(Control.PaddingProperty);
            setter.Value.Should().BeEquivalentTo(new Thickness(2));

            var padding = new Thickness(1);
            var setter2 = Setters.Padding(padding);

            setter2.Property.Should().Be(Control.PaddingProperty);
            setter2.Value.Should().BeEquivalentTo(padding);
        }
    }
}
