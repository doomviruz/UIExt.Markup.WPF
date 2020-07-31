using System.Threading.Tasks;
using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestToggleButtonExtensions
    {
        [TestMethod]
        public void TestIsChecked()
        {
            var control = ToggleButton();

            control.IsChecked(true).IsChecked.Should().Be(true);
        }

        [TestMethod]
        public void TestIsThreeState()
        {
            var control = ToggleButton();

            control.IsThreeState(true).IsThreeState.Should().Be(true);
        }

        [TestMethod]
        public void TestOnChecked()
        {
            var control = ToggleButton();
            var fired = false;

            control.OnChecked((_, e) => fired = true);
            control.IsChecked = true;

            fired.Should().Be(true);
        }

        [TestMethod]
        public void TestOnUnchecked()
        {
            var control = ToggleButton();
            var fired = false;

            control.IsChecked = true;
            control.OnUnchecked((_, e) => fired = true);
            control.IsChecked = false;

            fired.Should().Be(true);
        }

        [TestMethod]
        public void TestOnIndeterminate()
        {
            var control = ToggleButton();
            var fired = false;

            control.OnIndeterminate((_, e) => fired = true);
            control.IsChecked = null;

            fired.Should().Be(true);
        }
    }
}
