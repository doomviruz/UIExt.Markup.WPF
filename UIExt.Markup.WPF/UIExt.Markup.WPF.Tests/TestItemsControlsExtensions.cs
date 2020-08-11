using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestItemsControlsExtensions
    {
        [TestMethod]
        public void TestAlternationCount()
        {
            var lb = ListBox();

            lb.AlternationCount(3).AlternationCount.Should().Be(3);
        }

        [TestMethod]
        public void TestSetGroupStyleSelector()
        {
            var lb = ListBox();
            GroupStyleSelector selector = (group, level) => new GroupStyle();

            lb.SetGroupStyleSelector(selector).GroupStyleSelector.Should().Be(selector);
        }

        [TestMethod]
        public void TestItemsPanel()
        {
            var lb = ListBox();
            var template = new ItemsPanelTemplate();

            lb.ItemsPanel(template).ItemsPanel.Should().Be(template);
        }

        [TestMethod]
        public void TestItemContainerStyleSelector()
        {
            var lb = ListBox();
            var selector = new StyleSelector();

            lb.ItemContainerStyleSelector(selector).ItemContainerStyleSelector.Should().Be(selector);
        }

        [TestMethod]
        public void TestItemContainerStyle()
        {
            var lb = ListBox();
            var style = new Style();

            lb.ItemContainerStyle(style).ItemContainerStyle.Should().Be(style);
        }

        [TestMethod]
        public void TestItemBindingGroup()
        {
            var lb = ListBox();
            var group = new BindingGroup();

            lb.ItemBindingGroup(group).ItemBindingGroup.Should().Be(group);
        }

        [TestMethod]
        public void TestItemStringFormat()
        {
            var lb = ListBox();

            lb.ItemStringFormat("Some format").ItemStringFormat.Should().Be("Some format");
        }

        [TestMethod]
        public void TestItemTemplateSelector()
        {
            var lb = ListBox();
            var selector = new DataTemplateSelector();

            lb.ItemTemplateSelector(selector).ItemTemplateSelector.Should().Be(selector);
        }

        [TestMethod]
        public void TestItemTemplate()
        {
            var lb = ListBox();
            var template = new DataTemplate();

            lb.ItemTemplate(template).ItemTemplate.Should().Be(template);
        }

        [TestMethod]
        public void TestDisplayMemberPath()
        {
            var lb = ListBox();

            lb.DisplayMemberPath("Some path").DisplayMemberPath.Should().Be("Some path");
        }

        [TestMethod]
        public void TestItemsSource()
        {
            var lb = ListBox();
            var items = new int[] { };

            lb.ItemsSource(items).ItemsSource.Should().BeSameAs(items);
        }

        [TestMethod]
        public void TestIsTextSearchCaseSensitive()
        {
            var lb = ListBox();

            lb.IsTextSearchCaseSensitive(true).IsTextSearchCaseSensitive.Should().Be(true);
        }

        [TestMethod]
        public void TestIsTextSearchEnabled()
        {
            var lb = ListBox();

            lb.IsTextSearchEnabled(true).IsTextSearchEnabled.Should().Be(true);
        }
    }
}
