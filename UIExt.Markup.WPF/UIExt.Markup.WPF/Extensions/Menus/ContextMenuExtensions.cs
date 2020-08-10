using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace System.Windows
{
    public static class ContextMenuExtensions
    {
        public static T HorizontalOffset<T>(this T source, double value) where T : ContextMenu
        {
            source.HorizontalOffset = value;
            return source;
        }

        public static T StaysOpen<T>(this T source, bool value) where T : ContextMenu
        {
            source.StaysOpen = value;
            return source;
        }

        public static T PlacementCallback<T>(this T source, CustomPopupPlacementCallback value) where T : ContextMenu
        {
            source.CustomPopupPlacementCallback = value;
            return source;
        }

        public static T HasDropShadow<T>(this T source, bool value) where T : ContextMenu
        {
            source.HasDropShadow = value;
            return source;
        }

        public static T Placement<T>(this T source, PlacementMode value) where T : ContextMenu
        {
            source.Placement = value;
            return source;
        }

        public static T PlacementRectangle<T>(this T source, Rect value) where T : ContextMenu
        {
            source.PlacementRectangle = value;
            return source;
        }

        public static T PlacementTarget<T>(this T source, UIElement value) where T : ContextMenu
        {
            source.PlacementTarget = value;
            return source;
        }

        public static T IsOpen<T>(this T source, bool value) where T : ContextMenu
        {
            source.IsOpen = value;
            return source;
        }

        public static T VerticalOffset<T>(this T source, double value) where T : ContextMenu
        {
            source.VerticalOffset = value;
            return source;
        }
    }
}
