using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestRepeatButtonExtensions
    {
        [TestMethod]
        public void TestDelay()
        {
            var btn = RepeatButton();

            btn.Delay(42).Delay.Should().Be(42);
        }

        [TestMethod]
        public void TestInterval()
        {
            var btn = RepeatButton();

            btn.Interval(42).Interval.Should().Be(42);
        }
    }
}
