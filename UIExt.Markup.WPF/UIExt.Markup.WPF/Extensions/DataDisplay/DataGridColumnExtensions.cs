using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace System.Windows
{
    public static class DataGridColumnExtensions
    {
        public static T Header<T>(this T target, object value) where T : DataGridColumn
        {
            target.Header = value;
            return target;
        }

        public static T MinWidth<T>(this T target, double value) where T : DataGridColumn
        {
            target.MinWidth = value;
            return target;
        }

        public static T Width<T>(this T target, DataGridLength value) where T : DataGridColumn
        {
            target.Width = value;
            return target;
        }

        public static T IsReadOnly<T>(this T target, bool value) where T : DataGridColumn
        {
            target.IsReadOnly = value;
            return target;
        }

        public static T CellStyle<T>(this T target, Style value) where T : DataGridColumn
        {
            target.CellStyle = value;
            return target;
        }

        public static T HeaderTemplateSelector<T>(this T target, DataTemplateSelector value) where T : DataGridColumn
        {
            target.HeaderTemplateSelector = value;
            return target;
        }

        public static T HeaderTemplate<T>(this T target, DataTemplate value) where T : DataGridColumn
        {
            target.HeaderTemplate = value;
            return target;
        }

        public static T HeaderStringFormat<T>(this T target, string value) where T : DataGridColumn
        {
            target.HeaderStringFormat = value;
            return target;
        }

        public static T HeaderStyle<T>(this T target, Style value) where T : DataGridColumn
        {
            target.HeaderStyle = value;
            return target;
        }

        public static T CanUserResize<T>(this T target, bool value) where T : DataGridColumn
        {
            target.CanUserResize = value;
            return target;
        }

        public static T SortMemberPath<T>(this T target, string value) where T : DataGridColumn
        {
            target.SortMemberPath = value;
            return target;
        }

        public static T CanUserSort<T>(this T target, bool value) where T : DataGridColumn
        {
            target.CanUserSort = value;
            return target;
        }

        public static T SortDirection<T>(this T target, ListSortDirection? value) where T : DataGridColumn
        {
            target.SortDirection = value;
            return target;
        }

        public static T CanUserReorder<T>(this T target, bool value) where T : DataGridColumn
        {
            target.CanUserReorder = value;
            return target;
        }

        public static T DragIndicatorStyle<T>(this T target, Style value) where T : DataGridColumn
        {
            target.DragIndicatorStyle = value;
            return target;
        }

        public static T ClipboardContentBinding<T>(this T target, Data.BindingBase value) where T : DataGridColumn
        {
            target.ClipboardContentBinding = value;
            return target;
        }

        public static T MaxWidth<T>(this T target, double value) where T : DataGridColumn
        {
            target.MaxWidth = value;
            return target;
        }

        public static T Visibility<T>(this T target, Visibility value) where T : DataGridColumn
        {
            target.Visibility = value;
            return target;
        }

        public static T DisplayIndex<T>(this T target, int value) where T : DataGridColumn
        {
            target.DisplayIndex = value;
            return target;
        }
    }
}
