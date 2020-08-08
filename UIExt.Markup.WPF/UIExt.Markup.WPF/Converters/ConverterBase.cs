using System;
using System.Globalization;
using System.Windows.Data;

namespace UIExt.Markup.WPF.Converters
{
    public abstract class ConverterBase<TFrom, TTo> : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var castedValue = (TFrom)value;
            return Convert(castedValue, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var castedValue = (TTo)value;
            return ConvertBack(castedValue, culture);
        }

        public abstract TTo Convert(TFrom value, CultureInfo culture);

        public abstract TFrom ConvertBack(TTo value, CultureInfo culture);
    }
}
