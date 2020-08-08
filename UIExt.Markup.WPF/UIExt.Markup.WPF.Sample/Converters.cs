using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UIExt.Markup.WPF.Converters;

namespace UIExt.Markup.WPF.Sample
{
    public static class Converters
    {
        public readonly static BoolToVisibilityConverter BoolToVisibilityConverter = new BoolToVisibilityConverter();

        public readonly static FunctionalConverter<bool, Visibility> InvertBoolToVisibilityConverter 
            = new FunctionalConverter<bool, Visibility>(
                convert: (value, culture) => value ? Visibility.Hidden : Visibility.Visible,
                convertBack: (value, culture) => value != Visibility.Visible);
    }
}
