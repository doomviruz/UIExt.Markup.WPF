using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestComboBoxExtensions
    {
        [TestMethod]
        public void TestShouldPreserveUserEnteredPrefix()
        {
            var cb = ComboBox();

            cb.ShouldPreserveUserEnteredPrefix(true).ShouldPreserveUserEnteredPrefix.Should().BeTrue();
        }

        [TestMethod]
        public void TestIsEditable()
        {
            var cb = ComboBox();

            cb.IsEditable(false).IsEditable.Should().BeFalse();
        }

        [TestMethod]
        public void TestIsReadOnly()
        {
            var cb = ComboBox();

            cb.IsReadOnly(true).IsReadOnly.Should().BeTrue();
        }

        [TestMethod]
        public void TestText()
        {
            var cb = ComboBox();

            cb.Text("Some text").Text.Should().Be("Some text");
        }

        [TestMethod]
        public void TestMaxDropDownHeight()
        {
            var cb = ComboBox();

            cb.MaxDropDownHeight(100).MaxDropDownHeight.Should().Be(100);
        }

        [TestMethod]
        public void TestStaysOpenOnEdit()
        {
            var cb = ComboBox();

            cb.StaysOpenOnEdit(true).StaysOpenOnEdit.Should().BeTrue();
        }

        [TestMethod]
        public void TestIsDropDownOpen()
        {
            var wnd = Window();
            var cb = ComboBox();
            wnd.Content(cb);
            wnd.Show();

            cb.IsDropDownOpen(true).IsDropDownOpen.Should().BeTrue();

            wnd.Close();
        }
    }
}
