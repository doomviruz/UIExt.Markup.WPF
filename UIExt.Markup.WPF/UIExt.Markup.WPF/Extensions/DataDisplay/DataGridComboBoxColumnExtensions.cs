using System.Collections;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace System.Windows
{
    public static class DataGridComboBoxColumnExtensions
    {
        public static T ItemsSource<T>(this T target, IEnumerable value) where T : DataGridComboBoxColumn
        {
            target.ItemsSource = value;
            return target;
        }

        public static T ClipboardContentBinding<T>(this T target, BindingBase value) where T : DataGridComboBoxColumn
        {
            target.ClipboardContentBinding = value;
            return target;
        }

        public static T EditingElementStyle<T>(this T target, Style value) where T : DataGridComboBoxColumn
        {
            target.EditingElementStyle = value;
            return target;
        }

        public static T ElementStyle<T>(this T target, Style value) where T : DataGridComboBoxColumn
        {
            target.ElementStyle = value;
            return target;
        }

        public static T TextBinding<T>(this T target, BindingBase value) where T : DataGridComboBoxColumn
        {
            target.TextBinding = value;
            return target;
        }

        public static T SelectedItemBinding<T>(this T target, BindingBase value) where T : DataGridComboBoxColumn
        {
            target.SelectedItemBinding = value;
            return target;
        }

        public static T SelectedValueBinding<T>(this T target, BindingBase value) where T : DataGridComboBoxColumn
        {
            target.SelectedValueBinding = value;
            return target;
        }

        public static T SelectedValuePath<T>(this T target, string value) where T : DataGridComboBoxColumn
        {
            target.SelectedValuePath = value;
            return target;
        }

        public static T DisplayMemberPath<T>(this T target, string value) where T : DataGridComboBoxColumn
        {
            target.DisplayMemberPath = value;
            return target;
        }
    }
}
