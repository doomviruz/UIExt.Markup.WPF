using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestUIExt
    {
        [TestMethod]
        public void TestSolidBrush()
        {
            SolidBrush(0xFF, 0xFF, 0xFF, 0xFF).Color.Should().BeEquivalentTo(Colors.White);
            SolidBrush("#FFFFFFFF").Color.Should().BeEquivalentTo(Colors.White);
        }

        [TestMethod]
        public void TestSetter()
        {
            var setter = Setter(Control.BackgroundProperty, Brushes.White);

            setter.Property.Should().Be(Control.BackgroundProperty);
            setter.Value.Should().Be(Brushes.White);
        }

        [TestMethod]
        public void TestTrigger()
        {
            var trigger = Trigger(Control.BackgroundProperty, Brushes.Red, Control.ForegroundProperty, Brushes.Blue);

            trigger.Property.Should().Be(Control.BackgroundProperty);
            trigger.Value.Should().Be(Brushes.Red);
            trigger.Setters.First().Should().BeOfType<Setter>();
            trigger.Setters.First().As<Setter>().Property.Should().Be(Control.ForegroundProperty);
            trigger.Setters.First().As<Setter>().Value.Should().Be(Brushes.Blue);
        }

        [TestMethod]
        public void TestThumb()
        {
            Thumb().Should().NotBeNull();
        }
    }
}
