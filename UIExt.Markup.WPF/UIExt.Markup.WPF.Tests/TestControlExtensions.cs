using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestControlExtensions
    {
        [TestMethod]
        public void TestBorder()
        {
            var control = Button();

            control.Border(2).BorderThickness.Should().BeEquivalentTo(new Thickness(2));
        }

        [TestMethod]
        public void TestBorderThickness()
        {
            var control = Button();

            control.BorderThickness(new Thickness(1, 1, 0, 0)).BorderThickness.Should().BeEquivalentTo(new Thickness(1, 1, 0, 0));
        }

        [TestMethod]
        public void TestBorderBrush()
        {
            var control = Button();

            control.BorderBrush(Brushes.Red).BorderBrush.Should().BeEquivalentTo(Brushes.Red);
        }

        [TestMethod]
        public void TestFontSize()
        {
            var control = Button();

            control.FontSize(14).FontSize.Should().Be(14);
        }

        [TestMethod]
        public void TestFontFamily()
        {
            var control = Button();

            control.Font("SegoeUI").FontFamily.Should().BeEquivalentTo(new FontFamily("SegoeUI"));
        }

        [TestMethod]
        public void TestFontStretch()
        {
            var control = Button();

            control.FontStretch(FontStretches.Expanded).FontStretch.Should().BeEquivalentTo(FontStretches.Expanded);
        }


        [TestMethod]
        public void TestFontStyle()
        {
            var control = Button();

            control.FontStyle(FontStyles.Italic).FontStyle.Should().BeEquivalentTo(FontStyles.Italic);
        }

        [TestMethod]
        public void TestFontWeight()
        {
            var control = Button();

            control.FontWeight(FontWeights.Bold).FontWeight.Should().BeEquivalentTo(FontWeights.Bold);
        }

        [TestMethod]
        public void TestFontComplex()
        {
            var control = Button()
                .Font(family: "SegoeUI", size: 20, style: FontStyles.Normal, weight: FontWeights.SemiBold);

            control.FontFamily.Should().BeEquivalentTo(new FontFamily("SegoeUI"));
            control.FontSize.Should().Be(20);
            control.FontStyle.Should().Be(FontStyles.Normal);
            control.FontWeight.Should().Be(FontWeights.SemiBold);

            control.Font();

            control.FontFamily.Should().BeEquivalentTo(new FontFamily("SegoeUI"));
            control.FontSize.Should().Be(20);
            control.FontStyle.Should().Be(FontStyles.Normal);
            control.FontWeight.Should().Be(FontWeights.SemiBold);
        }

        [TestMethod]
        public void TestBackground()
        {
            var control = Button();

            control.Background(Brushes.White).Background.Should().BeEquivalentTo(Brushes.White);
        }

        [TestMethod]
        public void TestForeground()
        {
            var control = Button();

            control.Foreground(Brushes.White).Foreground.Should().BeEquivalentTo(Brushes.White);
        }

        [TestMethod]
        public void TestHorizontalContentAlignment()
        {
            var control = Button();

            control.HorizontalContentAlignment(HorizontalAlignment.Left).HorizontalContentAlignment.Should().Be(HorizontalAlignment.Left);
        }

        [TestMethod]
        public void TestVerticalContentAlignment()
        {
            var control = Button();

            control.VerticalContentAlignment(VerticalAlignment.Bottom).VerticalContentAlignment.Should().Be(VerticalAlignment.Bottom);
        }

        [TestMethod]
        public void TestIsTabStop()
        {
            var control = Button();

            control.IsTabStop(true).IsTabStop.Should().BeTrue();
        }

        [TestMethod]
        public void TestPadding()
        {
            var control = Button();

            control.Padding(new Thickness(1)).Padding.Should().BeEquivalentTo(new Thickness(1));
        }

        [TestMethod]
        public void TestTabIndex()
        {
            var control = Button();

            control.TabIndex(5).TabIndex.Should().Be(5);
        }

        [TestMethod]
        public void TestTemplate()
        {
            var control = Button();
            var template = new ControlTemplate();

            control.Template(template).Template.Should().Be(template);
        }
    }
}
