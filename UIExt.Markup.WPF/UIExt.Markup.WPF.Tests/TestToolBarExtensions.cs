using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestToolBarExtensions
    {
        [TestMethod]
        public void TestBand()
        {
            var tb = ToolBar();

            tb.Band(2).Band.Should().Be(2);
        }

        [TestMethod]
        public void TestBandIndex()
        {
            var tb = ToolBar();

            tb.BandIndex(2).BandIndex.Should().Be(2);
        }

        [TestMethod]
        public void TestIsOverflowOpen()
        {
            var tb = ToolBar();

            tb.IsOverflowOpen(false).IsOverflowOpen.Should().Be(false);
        }
    }
}
