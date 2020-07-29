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

        public static T BorderThickness<T>(this T target, Thickness value) where T : Control
        {
            target.BorderThickness = value;
            return target;
        }

        public static T BorderThickness<T>(this T target, double value) where T : Control
        {
            target.BorderThickness = new Thickness(value);
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

        public static T FontFamily<T>(this T target, FontFamily value) where T : Control
        {
            target.FontFamily = value;
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

        public static T TabIndex<T>(this T target, Int32 value) where T : Control
        {
            target.TabIndex = value;
            return target;
        }

        public static T IsTabStop<T>(this T target, Boolean value) where T : Control
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

        public static T OverridesDefaultStyle<T>(this T target, Boolean value) where T : Control
        {
            target.OverridesDefaultStyle = value;
            return target;
        }

        public static T UseLayoutRounding<T>(this T target, Boolean value) where T : Control
        {
            target.UseLayoutRounding = value;
            return target;
        }

        public static T Resources<T>(this T target, ResourceDictionary value) where T : Control
        {
            target.Resources = value;
            return target;
        }

        public static T DataContext<T>(this T target, Object value) where T : Control
        {
            target.DataContext = value;
            return target;
        }

        public static T BindingGroup<T>(this T target, BindingGroup value) where T : Control
        {
            target.BindingGroup = value;
            return target;
        }

        public static T Language<T>(this T target, XmlLanguage value) where T : Control
        {
            target.Language = value;
            return target;
        }

        public static T Tag<T>(this T target, Object value) where T : Control
        {
            target.Tag = value;
            return target;
        }

        public static T InputScope<T>(this T target, InputScope value) where T : Control
        {
            target.InputScope = value;
            return target;
        }

        public static T LayoutTransform<T>(this T target, Transform value) where T : Control
        {
            target.LayoutTransform = value;
            return target;
        }

        public static T MinHeight<T>(this T target, Double value) where T : Control
        {
            target.MinHeight = value;
            return target;
        }

        public static T MaxHeight<T>(this T target, Double value) where T : Control
        {
            target.MaxHeight = value;
            return target;
        }

        public static T FlowDirection<T>(this T target, FlowDirection value) where T : Control
        {
            target.FlowDirection = value;
            return target;
        }

        public static T Margin<T>(this T target, Thickness value) where T : Control
        {
            target.Margin = value;
            return target;
        }

        public static T HorizontalAlignment<T>(this T target, HorizontalAlignment value) where T : Control
        {
            target.HorizontalAlignment = value;
            return target;
        }

        public static T VerticalAlignment<T>(this T target, VerticalAlignment value) where T : Control
        {
            target.VerticalAlignment = value;
            return target;
        }

        public static T FocusVisualStyle<T>(this T target, Style value) where T : Control
        {
            target.FocusVisualStyle = value;
            return target;
        }

        public static T Cursor<T>(this T target, Cursor value) where T : Control
        {
            target.Cursor = value;
            return target;
        }

        public static T ForceCursor<T>(this T target, Boolean value) where T : Control
        {
            target.ForceCursor = value;
            return target;
        }

        public static T ToolTip<T>(this T target, Object value) where T : Control
        {
            target.ToolTip = value;
            return target;
        }

        public static T ContextMenu<T>(this T target, ContextMenu value) where T : Control
        {
            target.ContextMenu = value;
            return target;
        }

        public static T AllowDrop<T>(this T target, Boolean value) where T : Control
        {
            target.AllowDrop = value;
            return target;
        }

        public static T RenderSize<T>(this T target, Size value) where T : Control
        {
            target.RenderSize = value;
            return target;
        }

        public static T RenderTransform<T>(this T target, Transform value) where T : Control
        {
            target.RenderTransform = value;
            return target;
        }

        public static T RenderTransformOrigin<T>(this T target, Point value) where T : Control
        {
            target.RenderTransformOrigin = value;
            return target;
        }

        public static T Opacity<T>(this T target, Double value) where T : Control
        {
            target.Opacity = value;
            return target;
        }

        public static T OpacityMask<T>(this T target, Brush value) where T : Control
        {
            target.OpacityMask = value;
            return target;
        }

        public static T Effect<T>(this T target, Effect value) where T : Control
        {
            target.Effect = value;
            return target;
        }

        public static T CacheMode<T>(this T target, CacheMode value) where T : Control
        {
            target.CacheMode = value;
            return target;
        }

        public static T Uid<T>(this T target, String value) where T : Control
        {
            target.Uid = value;
            return target;
        }

        public static T Visibility<T>(this T target, Visibility value) where T : Control
        {
            target.Visibility = value;
            return target;
        }

        public static T ClipToBounds<T>(this T target, Boolean value) where T : Control
        {
            target.ClipToBounds = value;
            return target;
        }

        public static T Clip<T>(this T target, Geometry value) where T : Control
        {
            target.Clip = value;
            return target;
        }

        public static T SnapsToDevicePixels<T>(this T target, Boolean value) where T : Control
        {
            target.SnapsToDevicePixels = value;
            return target;
        }

        public static T IsEnabled<T>(this T target, Boolean value) where T : Control
        {
            target.IsEnabled = value;
            return target;
        }

        public static T IsHitTestVisible<T>(this T target, Boolean value) where T : Control
        {
            target.IsHitTestVisible = value;
            return target;
        }

        public static T Focusable<T>(this T target, Boolean value) where T : Control
        {
            target.Focusable = value;
            return target;
        }

        public static T IsManipulationEnabled<T>(this T target, Boolean value) where T : Control
        {
            target.IsManipulationEnabled = value;
            return target;
        }

    }
}
