using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace System.Windows
{
    public static class FrameworkElementExtensions
    {
        public static T Name<T>(this T target, string name) where T : FrameworkElement
        {
            target.Name = name;
            return target;
        }

        public static T Tag<T>(this T target, object tag) where T : FrameworkElement
        {
            target.Tag = tag;
            return target;
        }

        public static T DataContext<T>(this T target, object context) where T : FrameworkElement
        {
            target.DataContext = context;
            return target;
        }

        public static T Style<T>(this T target, Style style) where T : FrameworkElement
        {
            target.Style = style;
            return target;
        }

        public static T FocusStyle<T>(this T target, Style style) where T : FrameworkElement
        {
            target.FocusVisualStyle = style;
            return target;
        }

        public static T FocusStyleNone<T>(this T target) where T : FrameworkElement => target.FocusStyle(null);

        public static T ContextMenu<T>(this T target, ContextMenu menu) where T : FrameworkElement
        {
            target.ContextMenu = menu;
            return target;
        }

        public static T ToolTip<T>(this T target, object toolTip) where T : FrameworkElement
        {
            target.ToolTip = toolTip;
            return target;
        }

        public static T HAlign<T>(this T target, HorizontalAlignment alignment) where T : FrameworkElement
        {
            target.HorizontalAlignment = alignment;
            return target;
        }

        public static T VAlign<T>(this T target, VerticalAlignment alignment) where T : FrameworkElement
        {
            target.VerticalAlignment = alignment;
            return target;
        }

        public static T HAlignLeft<T>(this T target) where T : FrameworkElement => target.HAlign(HorizontalAlignment.Left);

        public static T HAlignCenter<T>(this T target) where T : FrameworkElement => target.HAlign(HorizontalAlignment.Center);

        public static T HAlignRight<T>(this T target) where T : FrameworkElement => target.HAlign(HorizontalAlignment.Right);

        public static T HAlignStretch<T>(this T target) where T : FrameworkElement => target.HAlign(HorizontalAlignment.Stretch);

        public static T VAlignTop<T>(this T target) where T : FrameworkElement => target.VAlign(VerticalAlignment.Top);

        public static T VAlignCenter<T>(this T target) where T : FrameworkElement => target.VAlign(VerticalAlignment.Center);

        public static T VAlignBottom<T>(this T target) where T : FrameworkElement => target.VAlign(VerticalAlignment.Bottom);

        public static T VAlignStretch<T>(this T target) where T : FrameworkElement => target.VAlign(VerticalAlignment.Stretch);

        public static T Height<T>(this T target, double height) where T : FrameworkElement
        {
            target.Height = height;
            return target;
        }

        public static T HeightAuto<T>(this T target) where T : FrameworkElement
        {
            target.Height = double.NaN;
            return target;
        }

        public static T MinHeight<T>(this T target, double height) where T : FrameworkElement
        {
            target.MinHeight = height;
            return target;
        }

        public static T MaxHeight<T>(this T target, double height) where T : FrameworkElement
        {
            target.MaxHeight = height;
            return target;
        }

        public static T Width<T>(this T target, double width) where T : FrameworkElement
        {
            target.Width = width;
            return target;
        }

        public static T WidthAuto<T>(this T target) where T : FrameworkElement
        {
            target.Width = double.NaN;
            return target;
        }

        public static T MinWidth<T>(this T target, double width) where T : FrameworkElement
        {
            target.MinWidth = width;
            return target;
        }

        public static T MaxWidth<T>(this T target, double width) where T : FrameworkElement
        {
            target.MaxWidth = width;
            return target;
        }

        public static T Margin<T>(this T target, double left, double top, double right, double bottom) where T : FrameworkElement
        {
            target.Margin = new Thickness(left, top, right, bottom);
            return target;
        }

        public static T Margin<T>(this T target, double margin) where T : FrameworkElement =>
            target.Margin(margin, margin, margin, margin);

        public static T OverridesDefaultStyle<T>(this T target, Boolean value) where T : FrameworkElement
        {
            target.OverridesDefaultStyle = value;
            return target;
        }

        public static T UseLayoutRounding<T>(this T target, Boolean value) where T : FrameworkElement
        {
            target.UseLayoutRounding = value;
            return target;
        }

        public static T Resources<T>(this T target, ResourceDictionary value) where T : FrameworkElement
        {
            target.Resources = value;
            return target;
        }

        public static T BindingGroup<T>(this T target, BindingGroup value) where T : FrameworkElement
        {
            target.BindingGroup = value;
            return target;
        }

        public static T Language<T>(this T target, XmlLanguage value) where T : FrameworkElement
        {
            target.Language = value;
            return target;
        }

        public static T InputScope<T>(this T target, InputScope value) where T : FrameworkElement
        {
            target.InputScope = value;
            return target;
        }

        public static T LayoutTransform<T>(this T target, Transform value) where T : FrameworkElement
        {
            target.LayoutTransform = value;
            return target;
        }

        public static T FlowDirection<T>(this T target, FlowDirection value) where T : FrameworkElement
        {
            target.FlowDirection = value;
            return target;
        }

        public static T Margin<T>(this T target, Thickness value) where T : FrameworkElement
        {
            target.Margin = value;
            return target;
        }

        public static T Cursor<T>(this T target, Cursor value) where T : FrameworkElement
        {
            target.Cursor = value;
            return target;
        }

        public static T ForceCursor<T>(this T target, Boolean value) where T : FrameworkElement
        {
            target.ForceCursor = value;
            return target;
        }
    }
}
