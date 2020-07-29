using System.Windows.Controls;

namespace System.Windows
{
    public static class ContentControlExtensions
    {
        public static T Content<T>(this T control, object content) where T : ContentControl
        {
            control.Content = content;
            return control;
        }

    }
}
