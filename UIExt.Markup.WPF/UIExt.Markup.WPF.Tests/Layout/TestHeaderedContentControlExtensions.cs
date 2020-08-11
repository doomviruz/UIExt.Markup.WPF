using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestHeaderedContentControlExtensions
    {
        [TestMethod]
        public void TestLastChildFill()
        {
            var cb = GroupBox();
            var selector = new DataTemplateSelector();

            cb.HeaderTemplateSelector(selector).HeaderTemplateSelector.Should().Be(selector);
        }

        [TestMethod]
        public void TestHeaderTemplate()
        {
            var cb = GroupBox();
            var template = new DataTemplate();

            cb.HeaderTemplate(template).HeaderTemplate.Should().Be(template);
        }

        [TestMethod]
        public void TestHeaderStringFormat()
        {
            var cb = GroupBox();

            cb.HeaderStringFormat("Some format").HeaderStringFormat.Should().Be("Some format");
        }

        [TestMethod]
        public void TestHeader()
        {
            var cb = GroupBox();
            var header = "HEADER";

            cb.Header(header).Header.Should().Be(header);
        }
    }
}
