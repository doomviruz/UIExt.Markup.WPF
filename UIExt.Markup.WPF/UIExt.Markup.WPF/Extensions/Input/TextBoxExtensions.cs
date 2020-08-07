using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace System.Windows
{
    public static class TextBoxExtensions
    {
        public static T Wrapping<T>(this T target, TextWrapping wrapping) where T : TextBox
        {
            target.TextWrapping = wrapping;
            return target;
        }

        public static T Wrap<T>(this T target) where T : TextBox => target.Wrapping(TextWrapping.Wrap);

        public static T NoWrap<T>(this T target) where T : TextBox => target.Wrapping(TextWrapping.NoWrap);

        public static T WrapWithOverflow<T>(this T target) where T : TextBox => target.Wrapping(TextWrapping.WrapWithOverflow);

        public static T VScroll<T>(this T target, ScrollBarVisibility visibility) where T : TextBoxBase
        {
            target.VerticalScrollBarVisibility = visibility;
            return target;
        }

        public static T VScrollDisabled<T>(this T target) where T : TextBoxBase => target.VScroll(ScrollBarVisibility.Disabled);

        public static T VScrollAuto<T>(this T target) where T : TextBoxBase => target.VScroll(ScrollBarVisibility.Auto);

        public static T VScrollHidden<T>(this T target) where T : TextBoxBase => target.VScroll(ScrollBarVisibility.Hidden);

        public static T VScrollVisible<T>(this T target) where T : TextBoxBase => target.VScroll(ScrollBarVisibility.Visible);

        public static T HScroll<T>(this T target, ScrollBarVisibility visibility) where T : TextBoxBase
        {
            target.HorizontalScrollBarVisibility = visibility;
            return target;
        }

        public static T HScrollDisabled<T>(this T target) where T : TextBoxBase => target.HScroll(ScrollBarVisibility.Disabled);

        public static T HScrollAuto<T>(this T target) where T : TextBoxBase => target.HScroll(ScrollBarVisibility.Auto);

        public static T HScrollHidden<T>(this T target) where T : TextBoxBase => target.HScroll(ScrollBarVisibility.Hidden);

        public static T HScrollVisible<T>(this T target) where T : TextBoxBase => target.HScroll(ScrollBarVisibility.Visible);

        public static T Text<T>(this T target, string text) where T : TextBox
        {
            target.Text = text;
            return target;
        }

        public static T ReadOnly<T>(this T target, bool val) where T : TextBoxBase
        {
            target.IsReadOnly = val;
            return target;
        }

        public static T ReadOnly<T>(this T target) where T : TextBoxBase
        {
            target.IsReadOnly = true;
            return target;
        }
    }
}
