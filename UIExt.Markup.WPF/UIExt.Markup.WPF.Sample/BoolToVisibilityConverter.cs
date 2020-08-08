using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UIExt.Markup.WPF.Converters;

namespace UIExt.Markup.WPF.Sample
{
    public class BoolToVisibilityConverter : ConverterBase<bool, Visibility>
    {
        public override Visibility Convert(bool value, CultureInfo culture) => value ? Visibility.Visible : Visibility.Hidden;

        public override bool ConvertBack(Visibility value, CultureInfo culture) => value == Visibility.Visible;
    }
}
