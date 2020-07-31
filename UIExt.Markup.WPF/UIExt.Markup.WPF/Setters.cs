using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UIExt.Markup.WPF
{
    public static class Setters
    {
        public static Setter SnapsToPixels(bool value) => new Setter(UIElement.SnapsToDevicePixelsProperty, value);

        public static Setter FontSize(double value) => new Setter(Control.FontSizeProperty, value);

        public static Setter Background(Brush value) => new Setter(Control.BackgroundProperty, value);

        public static Setter Foreground(Brush value) => new Setter(Control.ForegroundProperty, value);

        public static Setter BorderBrush(Brush value) => new Setter(Control.BorderBrushProperty, value);

        public static Setter BorderThickness(double value) => new Setter(Control.BorderThicknessProperty, new Thickness(value));

        public static Setter FontFamily(string value) => new Setter(Control.FontFamilyProperty, new FontFamily(value));

        public static Setter FontWeight(FontWeight value) => new Setter(Control.FontWeightProperty, value);

        public static Setter FontStyle(FontStyle value) => new Setter(Control.FontStyleProperty, value);

        public static Setter FontStretch(FontStretch value) => new Setter(Control.FontStretchProperty, value);

        public static Setter Template(ControlTemplate value) => new Setter(Control.TemplateProperty, value);

        public static Setter VContentAlign(VerticalAlignment value) => new Setter(Control.VerticalContentAlignmentProperty, value);

        public static Setter HContentAlign(HorizontalAlignment value) => new Setter(Control.HorizontalContentAlignmentProperty, value);

        public static Setter Padding(Thickness value) => new Setter(Control.PaddingProperty, value);

        public static Setter Padding(double value) => new Setter(Control.PaddingProperty, new Thickness(value));

        public static Setter IsTabStop(bool value) => new Setter(Control.IsTabStopProperty, value);

        public static Setter TabIndex(int value) => new Setter(Control.TabIndexProperty, value);
    }
}
