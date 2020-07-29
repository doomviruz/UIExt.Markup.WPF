using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace System.Windows
{
    public static class UIElementExtensions
    {
        public static void Add<T>(UIElementCollection @this, UIElement item) => @this.Add(item);

        public static T Row<T>(this T target, int row) where T : UIElement
        {
            System.Windows.Controls.Grid.SetRow(target, row);
            return target;
        }

        public static T Column<T>(this T target, int column) where T : UIElement
        {
            System.Windows.Controls.Grid.SetColumn(target, column);
            return target;
        }

        public static T AllowDrop<T>(this T target, Boolean value) where T : UIElement
        {
            target.AllowDrop = value;
            return target;
        }

        public static T RenderSize<T>(this T target, Size value) where T : UIElement
        {
            target.RenderSize = value;
            return target;
        }

        public static T RenderTransform<T>(this T target, Transform value) where T : UIElement
        {
            target.RenderTransform = value;
            return target;
        }

        public static T RenderTransformOrigin<T>(this T target, Point value) where T : UIElement
        {
            target.RenderTransformOrigin = value;
            return target;
        }

        public static T Opacity<T>(this T target, Double value) where T : UIElement
        {
            target.Opacity = value;
            return target;
        }

        public static T OpacityMask<T>(this T target, Brush value) where T : UIElement
        {
            target.OpacityMask = value;
            return target;
        }

        public static T Effect<T>(this T target, Effect value) where T : UIElement
        {
            target.Effect = value;
            return target;
        }

        public static T CacheMode<T>(this T target, CacheMode value) where T : UIElement
        {
            target.CacheMode = value;
            return target;
        }

        public static T Uid<T>(this T target, String value) where T : UIElement
        {
            target.Uid = value;
            return target;
        }

        public static T Visibility<T>(this T target, Visibility value) where T : UIElement
        {
            target.Visibility = value;
            return target;
        }

        public static T Visibile<T>(this T target) where T : UIElement => target.Visibility(Windows.Visibility.Visible);

        public static T Hidden<T>(this T target) where T : UIElement => target.Visibility(Windows.Visibility.Hidden);

        public static T Collapsed<T>(this T target) where T : UIElement => target.Visibility(Windows.Visibility.Collapsed);

        public static T ClipToBounds<T>(this T target, Boolean value) where T : UIElement
        {
            target.ClipToBounds = value;
            return target;
        }

        public static T Clip<T>(this T target, Geometry value) where T : UIElement
        {
            target.Clip = value;
            return target;
        }

        public static T SnapsToDevicePixels<T>(this T target, Boolean value) where T : UIElement
        {
            target.SnapsToDevicePixels = value;
            return target;
        }

        public static T IsEnabled<T>(this T target, Boolean value) where T : UIElement
        {
            target.IsEnabled = value;
            return target;
        }

        public static T IsHitTestVisible<T>(this T target, Boolean value) where T : UIElement
        {
            target.IsHitTestVisible = value;
            return target;
        }

        public static T Focusable<T>(this T target, Boolean value) where T : UIElement
        {
            target.Focusable = value;
            return target;
        }

        public static T IsManipulationEnabled<T>(this T target, Boolean value) where T : UIElement
        {
            target.IsManipulationEnabled = value;
            return target;
        }

    }
}
