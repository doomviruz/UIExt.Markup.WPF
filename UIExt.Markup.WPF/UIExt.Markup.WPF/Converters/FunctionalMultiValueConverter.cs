using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UIExt.Markup.WPF.Converters
{
    public class FunctionalMultiValueConverter<TFrom, TTo> : MultiValueConverterBase<TFrom, TTo>
    {
        private readonly Func<TFrom[], CultureInfo, TTo> _convert;

        private readonly Func<TTo, CultureInfo, TFrom[]> _convertBack;

        public FunctionalMultiValueConverter(Func<TFrom[], CultureInfo, TTo> convert, Func<TTo, CultureInfo, TFrom[]> convertBack)
        {
            _convert = convert ?? throw new ArgumentNullException(nameof(convert));
            _convertBack = convertBack ?? throw new ArgumentNullException(nameof(convertBack));
        }

        public override TTo Convert(TFrom[] values, CultureInfo culture) => _convert(values, culture);

        public override TFrom[] ConvertBack(TTo value, CultureInfo culture) => _convertBack(value, culture);
    }
}
