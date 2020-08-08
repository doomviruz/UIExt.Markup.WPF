using System;
using System.Globalization;
using System.Windows.Data;

namespace UIExt.Markup.WPF.Converters
{
    public abstract class ParameterizedConverterBase<TFrom, TTo, TParam, TConvertBackParam> : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var castedValue = value == null ? default(TFrom) : (TFrom)value;
            var castedParameter = parameter == null ? default(TParam) : (TParam)parameter;
            return Convert(castedValue, castedParameter, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var castedValue = value == null ? default(TTo) : (TTo)value;
            var castedParameter = parameter == null ? default(TConvertBackParam) : (TConvertBackParam)parameter;
            return ConvertBack(castedValue, castedParameter, culture);
        }

        public abstract TTo Convert(TFrom value, TParam parameter, CultureInfo culture);

        public abstract TFrom ConvertBack(TTo value, TConvertBackParam parameter, CultureInfo culture);
    }
}
