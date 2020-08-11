using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestExpanderExtensions
    {
        [TestMethod]
        public void TestExpandDirection()
        {
            var cb = Expander();

            cb.ExpandDirection(ExpandDirection.Right).ExpandDirection.Should().Be(ExpandDirection.Right);
        }

        [TestMethod]
        public void TestIsExpanded()
        {
            var cb = Expander();

            cb.IsExpanded(true).IsExpanded.Should().BeTrue();
        }
    }
}
