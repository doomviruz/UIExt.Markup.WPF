using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIExt.Markup.WPF.Converters
{
    public class FunctionalConverter<TFrom, TTo> : ConverterBase<TFrom, TTo>
    {
        private readonly Func<TFrom, CultureInfo, TTo> _convert;

        private readonly Func<TTo, CultureInfo, TFrom> _convertBack;

        public FunctionalConverter(Func<TFrom, CultureInfo, TTo> convert, Func<TTo, CultureInfo, TFrom> convertBack)
        {
            _convert = convert ?? throw new ArgumentNullException(nameof(convert));
            _convertBack = convertBack ?? throw new ArgumentNullException(nameof(convertBack));
        }

        public override TTo Convert(TFrom value, CultureInfo culture) => _convert(value, culture);

        public override TFrom ConvertBack(TTo value, CultureInfo culture) => _convertBack(value, culture);
    }
}
