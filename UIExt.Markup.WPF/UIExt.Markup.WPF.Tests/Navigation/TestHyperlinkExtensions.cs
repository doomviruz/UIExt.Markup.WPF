using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestHyperlinkExtensions
    {
        [TestMethod]
        public void TestTargetName()
        {
            var link = Hyperlink();

            link.TargetName("Some target").TargetName.Should().Be("Some target");
        }

        [TestMethod]
        public void TestNavigateUri()
        {
            var link = Hyperlink();
            var uri = new Uri("Page.xaml", UriKind.RelativeOrAbsolute);

            link.NavigateUri(uri).NavigateUri.Should().Be(uri);
        }

        [TestMethod]
        public void TestCommandTarget()
        {
            var link = Hyperlink();
            var target = Button();

            link.CommandTarget(target).CommandTarget.Should().Be(target);
        }

        [TestMethod]
        public void TestCommandParameter()
        {
            var link = Hyperlink();

            link.CommandParameter(1).CommandParameter.Should().Be(1);
        }

        [TestMethod]
        public void TestCommand()
        {
            var link = Hyperlink();
            var command = new CommandStub();

            link.Command(command).Command.Should().Be(command);
        }

    }
}
