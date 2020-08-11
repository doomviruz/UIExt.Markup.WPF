using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestPanelExtensions
    {
        [TestMethod]
        public void TestAdd()
        {
            var panel = StackPanel();

            panel.Add<Button>(Button());

            panel.Children.Count.Should().Be(1);
        }

        [TestMethod]
        public void TestChilds()
        {
            var panel = StackPanel();

            panel.Childs(Button(), ToggleButton()).Children.Count.Should().Be(2);
        }

        [TestMethod]
        public void TestIsItemsHost()
        {
            var panel = StackPanel();

            panel.IsItemsHost(true).IsItemsHost.Should().Be(true);
        }

        [TestMethod]
        public void TestBackground()
        {
            var panel = StackPanel();

            panel.Background(Brushes.Red).Background.Should().Be(Brushes.Red);
        }
    }
}
