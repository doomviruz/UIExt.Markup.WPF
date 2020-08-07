using System.Windows.Controls;
using System.Windows.Media;

namespace System.Windows
{
    public static class PageExtensions
    {
        public static T WindowHeight<T>(this T source, double value) where T : Page
        {
            source.WindowHeight = value;
            return source;
        }

        public static T WindowWidth<T>(this T source, double value) where T : Page
        {
            source.WindowWidth = value;
            return source;
        }

        public static T Background<T>(this T source, Brush value) where T : Page
        {
            source.Background = value;
            return source;
        }

        public static T Title<T>(this T source, string value) where T : Page
        {
            source.Title = value;
            return source;
        }

        public static T ShowsNavigationUI<T>(this T source, bool value) where T : Page
        {
            source.ShowsNavigationUI = value;
            return source;
        }

        public static T FontFamily<T>(this T source, string value) where T : Page
        {
            source.FontFamily = new FontFamily(value);
            return source;
        }

        public static T FontSize<T>(this T source, double value) where T : Page
        {
            source.FontSize = value;
            return source;
        }

        public static T Foreground<T>(this T source, Brush value) where T : Page
        {
            source.Foreground = value;
            return source;
        }

        public static T KeepAlive<T>(this T source, bool value) where T : Page
        {
            source.KeepAlive = value;
            return source;
        }

        public static T WindowTitle<T>(this T source, string value) where T : Page
        {
            source.WindowTitle = value;
            return source;
        }

        public static T Template<T>(this T source, ControlTemplate value) where T : Page
        {
            source.Template = value;
            return source;
        }

        public static T Content<T>(this T source, object value) where T : Page
        {
            source.Content = value;
            return source;
        }
    }
}
