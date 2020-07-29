using System.Windows.Controls;

namespace System.Windows
{
    public static class PanelExtensions
    {
        public static void Add<T>(this Panel target, UIElement item) => target.Children.Add(item);

        public static T Childs<T>(this T target, params UIElement[] childs) where T : Panel
        {
            target.Children.Clear();
            foreach (var child in childs)
            {
                target.Children.Add(child);
            }

            return target;
        }

    }
}
