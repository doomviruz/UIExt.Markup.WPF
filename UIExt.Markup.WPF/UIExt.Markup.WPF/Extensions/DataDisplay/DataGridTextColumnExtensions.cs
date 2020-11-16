using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace System.Windows
{
    public static class DataGridTextColumnExtensions
    {
        public static T FontStyle<T>(this T target, FontStyle value) where T : DataGridTextColumn
        {
            target.FontStyle = value;
            return target;
        }

        public static T FontSize<T>(this T target, double value) where T : DataGridTextColumn
        {
            target.FontSize = value;
            return target;
        }

        public static T FontFamily<T>(this T target, FontFamily value) where T : DataGridTextColumn
        {
            target.FontFamily = value;
            return target;
        }

        public static T FontFamily<T>(this T target, string value) where T : DataGridTextColumn
        {
            target.FontFamily = new FontFamily(value);
            return target;
        }

        public static T Foreground<T>(this T target, Brush value) where T : DataGridTextColumn
        {
            target.Foreground = value;
            return target;
        }

        public static T FontWeight<T>(this T target, FontWeight value) where T : DataGridTextColumn
        {
            target.FontWeight = value;
            return target;
        }
    }
}
