using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIExt.Markup.WPF.Converters
{
    public class ParameterizedFunctionalMultiValueConverter<TFrom, TTo, TParam, TConvertBackParam>
        : ParameterizedMultiValueConverterBase<TFrom, TTo, TParam, TConvertBackParam>
    {
        private readonly Func<TFrom[], TParam, CultureInfo, TTo> _convert;

        private readonly Func<TTo, TConvertBackParam, CultureInfo, TFrom[]> _convertBack;

        public ParameterizedFunctionalMultiValueConverter(
            Func<TFrom[], TParam, CultureInfo, TTo> convert, 
            Func<TTo, TConvertBackParam, CultureInfo, TFrom[]> convertBack)
        {
            _convert = convert ?? throw new ArgumentNullException(nameof(convert));
            _convertBack = convertBack ?? throw new ArgumentNullException(nameof(convertBack));
        }

        public override TTo Convert(TFrom[] values, TParam parameter, CultureInfo culture) => _convert(values, parameter, culture);

        public override TFrom[] ConvertBack(TTo value, TConvertBackParam parameter, CultureInfo culture) => _convertBack(value, parameter, culture);
    }
}
