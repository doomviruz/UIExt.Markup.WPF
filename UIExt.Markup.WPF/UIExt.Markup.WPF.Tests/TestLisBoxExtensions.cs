using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestLisBoxExtensions
    {
        [TestMethod]
        public void TestSelectionMode()
        {
            var lb = ListBox();

            lb.SelectionMode(SelectionMode.Multiple).SelectionMode.Should().Be(SelectionMode.Multiple);
        }
    }
}
