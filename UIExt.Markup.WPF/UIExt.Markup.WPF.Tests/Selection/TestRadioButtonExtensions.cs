using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestRadioButtonExtensions
    {
        [TestMethod]
        public void TestGroupName()
        {
            var rb = RadioButton();

            rb.Group("Some group").GroupName.Should().Be("Some group");
        }
    }
}
