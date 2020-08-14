using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UIExt.Markup.WPF.Converters
{
    public abstract class ParameterizedMultiValueConverterBase<TFrom, TTo, TParam, TConvertBackParam> : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var castedValues = values == null ? default(TFrom[]) : values.Cast<TFrom>().ToArray();
            var castedParameter = parameter == null ? default(TParam) : (TParam)parameter;
            return Convert(castedValues, castedParameter, culture);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var castedValue = value == null ? default(TTo) : (TTo)value;
            var castedParameter = parameter == null ? default(TConvertBackParam) : (TConvertBackParam)parameter;
            return ConvertBack(castedValue, castedParameter, culture).Cast<object>().ToArray();
        }

        public abstract TTo Convert(TFrom[] values, TParam parameter, CultureInfo culture);

        public abstract TFrom[] ConvertBack(TTo value, TConvertBackParam parameter, CultureInfo culture);
    }
}
