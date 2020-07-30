using System.Windows;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestTextBlockExtensions
    {
        [TestMethod]
        public void TestText()
        {
            var tb = TextBlock();

            tb.Text("Some text").Text.Should().Be("Some text");
        }

        [TestMethod]
        public void TestLineHeight()
        {
            var tb = TextBlock();

            tb.LineHeight(42).LineHeight.Should().Be(42);
        }

        [TestMethod]
        public void TestFontStyle()
        {
            var tb = TextBlock();

            tb.FontStyle(FontStyles.Oblique).FontStyle.Should().Be(FontStyles.Oblique);
            tb.FontStyleNormal().FontStyle.Should().Be(FontStyles.Normal);
            tb.FontStyleItalic().FontStyle.Should().Be(FontStyles.Italic);
            tb.FontStyleOblique().FontStyle.Should().Be(FontStyles.Oblique);
        }

        [TestMethod]
        public void TestFontWeight()
        {
            var tb = TextBlock();

            tb.FontWeight(FontWeights.Bold).FontWeight.Should().Be(FontWeights.Bold);
            tb.FontWeightBlack().FontWeight.Should().Be(FontWeights.Black);
            tb.FontWeightBold().FontWeight.Should().Be(FontWeights.Bold);
            tb.FontWeightDemiBold().FontWeight.Should().Be(FontWeights.DemiBold);
            tb.FontWeightExtraBlack().FontWeight.Should().Be(FontWeights.ExtraBlack);
            tb.FontWeightExtraBold().FontWeight.Should().Be(FontWeights.ExtraBold);
            tb.FontWeightExtraLight().FontWeight.Should().Be(FontWeights.ExtraLight);
            tb.FontWeightUltraBlack().FontWeight.Should().Be(FontWeights.UltraBlack);
            tb.FontWeightUltraBold().FontWeight.Should().Be(FontWeights.UltraBold);
            tb.FontWeightUltraLight().FontWeight.Should().Be(FontWeights.UltraLight);
            tb.FontWeightHeavy().FontWeight.Should().Be(FontWeights.Heavy);
            tb.FontWeightLight().FontWeight.Should().Be(FontWeights.Light);
            tb.FontWeightMedium().FontWeight.Should().Be(FontWeights.Medium);
            tb.FontWeightNormal().FontWeight.Should().Be(FontWeights.Normal);
            tb.FontWeightRegular().FontWeight.Should().Be(FontWeights.Regular);
            tb.FontWeightSemiBold().FontWeight.Should().Be(FontWeights.SemiBold);
            tb.FontWeightThin().FontWeight.Should().Be(FontWeights.Thin);
        }

        [TestMethod]
        public void TestFont()
        {
            var tb = TextBlock();

            tb.Font("SegoeUI").FontFamily.Should().BeEquivalentTo(new FontFamily("SegoeUI"));
        }

        [TestMethod]
        public void TestFontSize()
        {
            var tb = TextBlock();

            tb.FontSize(42).FontSize.Should().Be(42);
        }
        [TestMethod]
        public void TestForeground()
        {
            var tb = TextBlock();

            tb.Foreground(Brushes.Yellow).Foreground.Should().Be(Brushes.Yellow);
        }
    }
}
