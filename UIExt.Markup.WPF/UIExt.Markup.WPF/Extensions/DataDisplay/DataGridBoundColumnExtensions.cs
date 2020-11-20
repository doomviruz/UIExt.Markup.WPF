using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace System.Windows
{
    public static class DataGridBoundColumnExtensions
    {
        public static T Binding<T>(this T target, BindingBase value) where T : DataGridBoundColumn
        {
            target.Binding = value;
            return target;
        }

        public static T ElementStyle<T>(this T target, Style value) where T : DataGridBoundColumn
        {
            target.ElementStyle = value;
            return target;
        }

        public static T EditingElementStyle<T>(this T target, Style value) where T : DataGridBoundColumn
        {
            target.EditingElementStyle = value;
            return target;
        }

        public static T ClipboardContentBinding<T>(this T target, BindingBase value) where T : DataGridBoundColumn
        {
            target.ClipboardContentBinding = value;
            return target;
        }
    }
}
