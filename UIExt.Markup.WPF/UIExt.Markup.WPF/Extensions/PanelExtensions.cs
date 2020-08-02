using System.Windows.Controls;
using System.Windows.Media;

namespace System.Windows
{
    public static class PanelExtensions
    {
        public static void Add<T>(this Panel target, UIElement item) where T : UIElement => target.Children.Add(item);

        public static T Childs<T>(this T target, params UIElement[] childs) where T : Panel
        {
            target.Children.Clear();
            foreach (var child in childs)
            {
                target.Children.Add(child);
            }

            return target;
        }

        public static T IsItemsHost<T>(this T target, bool value) where T : Panel
        {
            target.IsItemsHost = value;
            return target;
        }

        public static T Background<T>(this T target, Brush value) where T : Panel
        {
            target.Background = value;
            return target;
        }
    }
}
