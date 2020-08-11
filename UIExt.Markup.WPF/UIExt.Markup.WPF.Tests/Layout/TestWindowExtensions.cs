using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shell;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestWindowExtensions
    {
        [TestMethod]
        public void TestShowInTaskbar()
        {
            var wnd = Window();

            wnd.ShowInTaskbar(false).ShowInTaskbar.Should().BeFalse();
        }

        [TestMethod]
        public void TestStartupLocation()
        {
            var wnd = Window();

            wnd.StartupLocation(WindowStartupLocation.Manual).WindowStartupLocation.Should().Be(WindowStartupLocation.Manual);
        }

        [TestMethod]
        public void TestTaskbarItemInfo()
        {
            var wnd = Window();
            var item = new TaskbarItemInfo();

            wnd.TaskbarItemInfo(item).TaskbarItemInfo.Should().Be(item);
        }

        [TestMethod]
        public void TestTop()
        {
            var wnd = Window();

            wnd.Top(42).Top.Should().Be(42);
        }

        [TestMethod]
        public void TestSizeToContent()
        {
            var wnd = Window();

            wnd.SizeToContent(SizeToContent.Width).SizeToContent.Should().Be(SizeToContent.Width);
        }

        [TestMethod]
        public void TestAllowsTransparency()
        {
            var wnd = Window();

            wnd.AllowsTransparency(true).AllowsTransparency.Should().BeTrue();
        }

        [TestMethod]
        public void TestOwner()
        {
            var owner = Window().State(WindowState.Minimized).ShowInTaskbar(false);
            owner.Show();
            var wnd = Window();

            wnd.Owner(owner).Owner.Should().Be(owner);
            owner.Close();
        }

        [TestMethod]
        public void TestLeft()
        {
            var wnd = Window();

            wnd.Left(42).Left.Should().Be(42);
        }

        [TestMethod]
        public void TestIcon()
        {
            var wnd = Window();
            var icon = new BitmapImage();

            wnd.Icon(icon).Icon.Should().Be(icon);
        }

        [TestMethod]
        public void TestWindowStyle()
        {
            var wnd = Window();

            wnd.WindowStyle(WindowStyle.SingleBorderWindow).WindowStyle.Should().Be(WindowStyle.SingleBorderWindow);
        }

        [TestMethod]
        public void TestState()
        {
            var wnd = Window();

            wnd.State(WindowState.Maximized).WindowState.Should().Be(WindowState.Maximized);
        }

        [TestMethod]
        public void TestResizeMode()
        {
            var wnd = Window();

            wnd.ResizeMode(ResizeMode.CanResizeWithGrip).ResizeMode.Should().Be(ResizeMode.CanResizeWithGrip);
        }

        [TestMethod]
        public void TestTopmost()
        {
            var wnd = Window();

            wnd.Topmost(true).Topmost.Should().BeTrue();
        }

        [TestMethod]
        public void TestShowActivated()
        {
            var wnd = Window();

            wnd.ShowActivated(false).ShowActivated.Should().BeFalse();
        }

        [TestMethod]
        public void TestTitle()
        {
            var wnd = Window();

            wnd.Title("Some title").Title.Should().Be("Some title");
        }
    }
}
