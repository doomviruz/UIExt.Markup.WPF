using System;
using System.Globalization;
using System.Windows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UIExt.Markup.WPF.Converters;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestConverters
    {
        [TestMethod]
        public void TestFunctionalConverter()
        {
            var converter = new FunctionalConverter<bool, Visibility>(
                convert: (value, culture) => value ? Visibility.Visible : Visibility.Hidden,
                convertBack: (value, culture) => value == Visibility.Visible);

            converter.Convert(null, null, null, CultureInfo.CurrentCulture).Should().Be(Visibility.Hidden);
            converter.Convert(true, null, null, CultureInfo.CurrentCulture).Should().Be(Visibility.Visible);

            converter.ConvertBack(null, null, null, CultureInfo.CurrentCulture).Should().Be(true);
            converter.ConvertBack(Visibility.Hidden, null, null, CultureInfo.CurrentCulture).Should().Be(false);
        }

        [TestMethod]
        public void TestParameterizedFunctionalConverter()
        {
            var converter = new ParameterizedFunctionalConverter<bool, Visibility, int, int>(
                convert: (value, parameter, culture) => value ? Visibility.Visible : Visibility.Hidden,
                convertBack: (value, parameter, culture) => value == Visibility.Visible);

            converter.Convert(null, null, 1, CultureInfo.CurrentCulture).Should().Be(Visibility.Hidden);
            converter.Convert(true, null, null, CultureInfo.CurrentCulture).Should().Be(Visibility.Visible);

            converter.ConvertBack(null, null, 1, CultureInfo.CurrentCulture).Should().Be(true);
            converter.ConvertBack(Visibility.Hidden, null, null, CultureInfo.CurrentCulture).Should().Be(false);
        }
    }
}
