using System.Windows;
using System.Windows.Controls.Primitives;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestTriggerDefs
    {
        [TestMethod]
        public void TestIsPressed()
        {
            var trigger = TriggerDefs.IsPressed(UIExt.Setter());

            trigger.Property.Should().Be(ButtonBase.IsPressedProperty);
            trigger.Value.Should().Be(true);
            trigger.Setters.Count.Should().Be(1);
        }

        [TestMethod]
        public void TestIsMouseOver()
        {
            var trigger = TriggerDefs.IsMouseOver(UIExt.Setter());

            trigger.Property.Should().Be(UIElement.IsMouseOverProperty);
            trigger.Value.Should().Be(true);
            trigger.Setters.Count.Should().Be(1);
        }

        [TestMethod]
        public void TestIsEnabled()
        {
            var trigger = TriggerDefs.IsEnabled(UIExt.Setter());

            trigger.Property.Should().Be(UIElement.IsEnabledProperty);
            trigger.Value.Should().Be(true);
            trigger.Setters.Count.Should().Be(1);
        }

        [TestMethod]
        public void TestIsDisabled()
        {
            var trigger = TriggerDefs.IsDisabled(UIExt.Setter());

            trigger.Property.Should().Be(UIElement.IsEnabledProperty);
            trigger.Value.Should().Be(false);
            trigger.Setters.Count.Should().Be(1);
        }
    }
}
