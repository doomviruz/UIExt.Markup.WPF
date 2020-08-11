using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{

    [TestClass]
    public class TestMenuBaseExtensions
    {
        class TemplateSelectorMock : ItemContainerTemplateSelector
        {

        }

        [TestMethod]
        public void TestItemContainerTemplateSelector()
        {
            var menu = Menu();
            var selector = new TemplateSelectorMock();

            menu.ItemContainerTemplateSelector(selector).ItemContainerTemplateSelector.Should().Be(selector);
        }

        [TestMethod]
        public void TestUsesItemContainerTemplate()
        {
            var menu = Menu();

            menu.UsesItemContainerTemplate(true).UsesItemContainerTemplate.Should().Be(true);
        }
    }
}
