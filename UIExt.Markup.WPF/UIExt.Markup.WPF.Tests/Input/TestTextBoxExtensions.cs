using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestTextBoxExtensions
    {
        [TestMethod]
        public void TestWrapping()
        {
            var tb = TextBox();

            tb.Wrapping(TextWrapping.WrapWithOverflow).TextWrapping.Should().Be(TextWrapping.WrapWithOverflow);
            tb.Wrap().TextWrapping.Should().Be(TextWrapping.Wrap);
            tb.WrapWithOverflow().TextWrapping.Should().Be(TextWrapping.WrapWithOverflow);
            tb.NoWrap().TextWrapping.Should().Be(TextWrapping.NoWrap);
        }

        [TestMethod]
        public void TestVScroll()
        {
            var tb = TextBox();

            tb.VScroll(ScrollBarVisibility.Hidden).VerticalScrollBarVisibility.Should().Be(ScrollBarVisibility.Hidden);
            tb.VScrollAuto().VerticalScrollBarVisibility.Should().Be(ScrollBarVisibility.Auto);
            tb.VScrollDisabled().VerticalScrollBarVisibility.Should().Be(ScrollBarVisibility.Disabled);
            tb.VScrollVisible().VerticalScrollBarVisibility.Should().Be(ScrollBarVisibility.Visible);
            tb.VScrollHidden().VerticalScrollBarVisibility.Should().Be(ScrollBarVisibility.Hidden);
        }

        [TestMethod]
        public void TestHScroll()
        {
            var tb = TextBox();

            tb.HScroll(ScrollBarVisibility.Hidden).HorizontalScrollBarVisibility.Should().Be(ScrollBarVisibility.Hidden);
            tb.HScrollAuto().HorizontalScrollBarVisibility.Should().Be(ScrollBarVisibility.Auto);
            tb.HScrollDisabled().HorizontalScrollBarVisibility.Should().Be(ScrollBarVisibility.Disabled);
            tb.HScrollVisible().HorizontalScrollBarVisibility.Should().Be(ScrollBarVisibility.Visible);
            tb.HScrollHidden().HorizontalScrollBarVisibility.Should().Be(ScrollBarVisibility.Hidden);
        }

        [TestMethod]
        public void TestReadOnly()
        {
            var tb = TextBox();

            tb.ReadOnly().IsReadOnly.Should().BeTrue();
            tb.ReadOnly(false).IsReadOnly.Should().BeFalse();
        }

        [TestMethod]
        public void TestText()
        {
            var tb = TextBox();

            tb.Text("Some text").Text.Should().Be("Some text");
        }
    }
}
