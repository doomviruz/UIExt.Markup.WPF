using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestSelectorExtensions
    {
        [TestMethod]
        public void TestSelectedValue()
        {
            var cb = ComboBox();
            var value = 42;

            cb.SelectedValue(value).SelectedValue.Should().Be(value);
        }

        [TestMethod]
        public void TestSelectedItem()
        {
            var cb = ComboBox();
            cb.Items.Add(1);
            cb.Items.Add(3);
            cb.Items.Add(42);

            cb.SelectedItem(42).SelectedItem.Should().Be(42);
        }

        [TestMethod]
        public void TestSelectedIndex()
        {
            var cb = ComboBox();
            cb.Items.Add(1);
            cb.Items.Add(3);
            cb.Items.Add(42);

            cb.SelectedIndex(1).SelectedIndex.Should().Be(1);
        }

        [TestMethod]
        public void TestIsSynchronizedWithCurrentItem()
        {
            var cb = ComboBox();

            cb.IsSynchronizedWithCurrentItem(true).IsSynchronizedWithCurrentItem.Should().BeTrue();
        }

        [TestMethod]
        public void TestSelectedValuePath()
        {
            var cb = ComboBox();

            cb.SelectedValuePath("Path").SelectedValuePath.Should().Be("Path");
        }
    }
}
