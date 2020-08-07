using System.Windows.Controls;

namespace System.Windows
{
    public static class WrapPanelExtensions
    {
        public static T Orientation<T>(this T target, Orientation value) where T : WrapPanel
        {
            target.Orientation = value;
            return target;
        }

        public static T ItemWidth<T>(this T target, double value) where T : WrapPanel
        {
            target.ItemWidth = value;
            return target;
        }

        public static T ItemHeight<T>(this T target, double value) where T : WrapPanel
        {
            target.ItemHeight = value;
            return target;
        }
    }
}
