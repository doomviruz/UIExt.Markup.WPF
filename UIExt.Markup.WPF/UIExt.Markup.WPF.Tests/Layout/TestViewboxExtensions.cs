using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestViewboxExtensions
    {
        [TestMethod]
        public void TestChild()
        {
            var cb = Viewbox();
            var child = Button();

            cb.Child(child).Child.Should().Be(child);
        }

        [TestMethod]
        public void TestStretch()
        {
            var cb = Viewbox();

            cb.Stretch(Stretch.Uniform).Stretch.Should().Be(Stretch.Uniform);
        }

        [TestMethod]
        public void TestStretchDirection()
        {
            var cb = Viewbox();

            cb.StretchDirection(StretchDirection.UpOnly).StretchDirection.Should().Be(StretchDirection.UpOnly);
        }
    }
}
