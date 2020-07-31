using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace System.Windows
{
    public static class ControlExtensions
    {
        public static T Border<T>(this T target, double thickness) where T : Control
        {
            target.BorderThickness = new Thickness(thickness);
            return target;
        }

        public static T BorderBrush<T>(this T target, Brush brush) where T : Control
        {
            target.BorderBrush = brush;
            return target;
        }

        public static T FontSize<T>(this T target, double size) where T : Control
        {
            target.FontSize = size;
            return target;
        }

        public static T Font<T>(this T target, string family) where T : Control
        {
            target.FontFamily = new FontFamily(family);
            return target;
        }

        public static T Font<T>(this T target, string family = null, double? size = null, FontStyle? style = null, FontWeight? weight = null) where T : Control
        {
            if (!string.IsNullOrEmpty(family))
            {
                target.Font(family);
            }

            if (size.HasValue)
            {
                target.FontSize(size.Value);
            }

            if (style.HasValue)
            {
                target.FontStyle(style.Value);
            }

            if (weight.HasValue)
            {
                target.FontWeight(weight.Value);
            }

            return target;
        }

        public static T BorderThickness<T>(this T target, Thickness value) where T : Control
        {
            target.BorderThickness = value;
            return target;
        }

        public static T Background<T>(this T target, Brush value) where T : Control
        {
            target.Background = value;
            return target;
        }

        public static T Foreground<T>(this T target, Brush value) where T : Control
        {
            target.Foreground = value;
            return target;
        }

        public static T FontStretch<T>(this T target, FontStretch value) where T : Control
        {
            target.FontStretch = value;
            return target;
        }

        public static T FontStyle<T>(this T target, FontStyle value) where T : Control
        {
            target.FontStyle = value;
            return target;
        }

        public static T FontWeight<T>(this T target, FontWeight value) where T : Control
        {
            target.FontWeight = value;
            return target;
        }

        public static T HorizontalContentAlignment<T>(this T target, HorizontalAlignment value) where T : Control
        {
            target.HorizontalContentAlignment = value;
            return target;
        }

        public static T VerticalContentAlignment<T>(this T target, VerticalAlignment value) where T : Control
        {
            target.VerticalContentAlignment = value;
            return target;
        }

        public static T TabIndex<T>(this T target, int value) where T : Control
        {
            target.TabIndex = value;
            return target;
        }

        public static T IsTabStop<T>(this T target, bool value) where T : Control
        {
            target.IsTabStop = value;
            return target;
        }

        public static T Padding<T>(this T target, Thickness value) where T : Control
        {
            target.Padding = value;
            return target;
        }

        public static T Template<T>(this T target, ControlTemplate value) where T : Control
        {
            target.Template = value;
            return target;
        }
    }
}
