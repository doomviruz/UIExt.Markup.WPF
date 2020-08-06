using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestRangeBaseExtensions
    {
        [TestMethod]
        public void TestLargeChange()
        {
            var cb = ScrollBar();

            cb.LargeChange(42).LargeChange.Should().Be(42);
        }

        [TestMethod]
        public void TestSmallChange()
        {
            var cb = ScrollBar();

            cb.SmallChange(42).SmallChange.Should().Be(42);
        }

        [TestMethod]
        public void TestValue()
        {
            var cb = ScrollBar();
            cb
                .Maximum(100)
                .Minimum(0)
                .Value(42)
                .Value.Should().Be(42);
        }

        [TestMethod]
        public void TestMaximum()
        {
            var cb = ScrollBar();

            cb.Maximum(42).Maximum.Should().Be(42);
        }

        [TestMethod]
        public void TestMinimum()
        {
            var cb = ScrollBar();

            cb.Minimum(42).Minimum.Should().Be(42);
        }

    }
}
