using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestScrollbarExtensions
    {
        [TestMethod]
        public void TestOrientation()
        {
            var cb = ScrollBar();

            cb.Orientation(Orientation.Horizontal).Orientation.Should().Be(Orientation.Horizontal);
        }

        [TestMethod]
        public void TestViewportSize()
        {
            var cb = ScrollBar();

            cb.ViewportSize(42).ViewportSize.Should().Be(42);
        }
    }
}
