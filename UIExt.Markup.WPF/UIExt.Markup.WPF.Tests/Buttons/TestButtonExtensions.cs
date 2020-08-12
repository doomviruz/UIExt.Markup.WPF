using System;
using System.Windows;
using System.Windows.Input;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestButtonExtensions
    {
        [TestMethod]
        public void TestCommand()
        {
            var control = Button();
            var command = new CommandStub();

            control.Command(command);

            control.Command.Should().Be(command);
        }

        [TestMethod]
        // TODO: Find a method to ensure that event handler attached successfully
        public void TestOnClick()
        {
            var control = Button();
            RoutedEventHandler handler = (sender, args) => { };

            control.OnClick(handler);
        }
    }
}
