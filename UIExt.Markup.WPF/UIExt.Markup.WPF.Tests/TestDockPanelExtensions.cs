using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestDockPanelExtensions
    {
        [TestMethod]
        public void TestLastChildFill()
        {
            var cb = DockPanel();

            cb.LastChildFill(true).LastChildFill.Should().BeTrue();
        }

    }
}
