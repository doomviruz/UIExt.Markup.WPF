using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestContentControlExtensions
    {
        [TestMethod]
        public void TestContent()
        {
            var control = Window();

            control.Content("Some text").Content.Should().Be("Some text");
        }
    }
}
