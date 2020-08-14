using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace UIExt.Markup.WPF.Converters
{
    public abstract class MultiValueConverterBase<TFrom, TTo> : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var castedValues = values == null ? default(TFrom[]) : values.Cast<TFrom>().ToArray();
            return Convert(castedValues, culture);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            var castedValue = value == null ? default(TTo) : (TTo)value;
            return ConvertBack(castedValue, culture).Cast<object>().ToArray();
        }

        public abstract TTo Convert(TFrom[] value, CultureInfo culture);

        public abstract TFrom[] ConvertBack(TTo value, CultureInfo culture);
    }
}
