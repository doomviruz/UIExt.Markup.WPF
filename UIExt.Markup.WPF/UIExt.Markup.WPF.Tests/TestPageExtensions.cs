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
    public class TestPageExtensions
    {
        [TestMethod]
        public void TestWindowHeight()
        {
            var window = Window();
            var page = Page();
            window.Content(page);

            page.WindowHeight(200).WindowHeight.Should().Be(200);
        }

        [TestMethod]
        public void TestWindowWidth()
        {
            var window = Window();
            var page = Page();
            window.Content(page);

            page.WindowWidth(200).WindowWidth.Should().Be(200);
        }

        [TestMethod]
        public void TestBackground()
        {
            var page = Page();

            page.Background(Brushes.Red).Background.Should().Be(Brushes.Red);
        }

        [TestMethod]
        public void TestTitle()
        {
            var page = Page();

            page.Title("Page title").Title.Should().Be("Page title");
        }

        [TestMethod]
        public void TestShowsNavigationUI()
        {
            var window = new Window();
            var page = Page();
            window.Content(page);

            page.ShowsNavigationUI(false).ShowsNavigationUI.Should().Be(false);
        }

        [TestMethod]
        public void TestFontFamily()
        {
            var page = Page();

            page.FontFamily("Arial").FontFamily.Should().BeEquivalentTo(new FontFamily("Arial"));
        }

        [TestMethod]
        public void TestFontSize()
        {
            var page = Page();

            page.FontSize(20).FontSize.Should().Be(20);
        }

        [TestMethod]
        public void TestForeground()
        {
            var page = Page();

            page.Foreground(Brushes.Yellow).Foreground.Should().Be(Brushes.Yellow);
        }

        [TestMethod]
        public void TestKeepAlive()
        {
            var page = Page();

            page.KeepAlive(true).KeepAlive.Should().Be(true);
        }

        [TestMethod]
        public void TestWindowTitle()
        {
            var window = Window();
            var page = Page();
            window.Content(page);

            page.WindowTitle("Some title").WindowTitle.Should().Be("Some title");
        }

        [TestMethod]
        public void TestTemplate()
        {
            var page = Page();
            var template = new ControlTemplate();

            page.Template(template).Template.Should().Be(template);
        }

        [TestMethod]
        public void TestContent()
        {
            var page = Page();
            var content = "Some content";

            page.Content(content).Content.Should().Be(content);
        }
    }
}
