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
    public class TestFrameExtensions
    {
        [TestMethod]
        public void TestNavigationUIVisibility()
        {
            var frame = Frame();

            frame.NavigationUIVisibility(NavigationUIVisibility.Hidden).NavigationUIVisibility.Should().Be(NavigationUIVisibility.Hidden);
        }

        [TestMethod]
        public void TestJournalOwnership()
        {
            var frame = Frame();

            frame.JournalOwnership(JournalOwnership.OwnsJournal).JournalOwnership.Should().Be(JournalOwnership.OwnsJournal);
        }

        [TestMethod]
        public void TestSandboxExternalContent()
        {
            var frame = Frame();

            frame.SandboxExternalContent(true).SandboxExternalContent.Should().Be(true);
        }

        [TestMethod]
        public void TestSource()
        {
            var frame = Frame();
            var uri = new Uri("Page.xaml", UriKind.RelativeOrAbsolute);

            frame.Source(uri).Source.Should().Be(uri);
        }
    }
}
