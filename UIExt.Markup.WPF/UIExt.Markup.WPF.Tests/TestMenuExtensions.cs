using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestMenuExtensions
    {
        [TestMethod]
        public void TestIsMainMenu()
        {
            var menu = Menu();

            menu.IsMainMenu(true).IsMainMenu.Should().BeTrue();
        }
    }
}
