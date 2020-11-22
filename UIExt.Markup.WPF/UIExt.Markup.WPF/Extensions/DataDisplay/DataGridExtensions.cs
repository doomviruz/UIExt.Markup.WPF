using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace System.Windows
{
    public static class DataGridExtensions
    {
        public static T RowHeaderTemplate<T>(this T target, DataTemplate value) where T : DataGrid
        {
            target.RowHeaderTemplate = value;
            return target;
        }

        public static T RowHeaderTemplateSelector<T>(this T target, DataTemplateSelector value) where T : DataGrid
        {
            target.RowHeaderTemplateSelector = value;
            return target;
        }

        public static T VerticalScrollBarVisibility<T>(this T target, ScrollBarVisibility value) where T : DataGrid
        {
            target.VerticalScrollBarVisibility = value;
            return target;
        }

        public static T HorizontalScrollBarVisibility<T>(this T target, ScrollBarVisibility value) where T : DataGrid
        {
            target.HorizontalScrollBarVisibility = value;
            return target;
        }

        public static T CanUserAddRows<T>(this T target, bool value) where T : DataGrid
        {
            target.CanUserAddRows = value;
            return target;
        }

        public static T CurrentItem<T>(this T target, object value) where T : DataGrid
        {
            target.CurrentItem = value;
            return target;
        }

        public static T CurrentColumn<T>(this T target, DataGridColumn value) where T : DataGrid
        {
            target.CurrentColumn = value;
            return target;
        }

        public static T CurrentCell<T>(this T target, DataGridCellInfo value) where T : DataGrid
        {
            target.CurrentCell = value;
            return target;
        }

        public static T CanUserDeleteRows<T>(this T target, bool value) where T : DataGrid
        {
            target.CanUserDeleteRows = value;
            return target;
        }

        public static T RowHeaderStyle<T>(this T target, Style value) where T : DataGrid
        {
            target.RowHeaderStyle = value;
            return target;
        }

        public static T RowDetailsVisibilityMode<T>(this T target, DataGridRowDetailsVisibilityMode value) where T : DataGrid
        {
            target.RowDetailsVisibilityMode = value;
            return target;
        }

        public static T IsReadOnly<T>(this T target, bool value) where T : DataGrid
        {
            target.IsReadOnly = value;
            return target;
        }

        public static T ColumnHeaderStyle<T>(this T target, Style value) where T : DataGrid
        {
            target.ColumnHeaderStyle = value;
            return target;
        }

        public static T RowStyle<T>(this T target, Style value) where T : DataGrid
        {
            target.RowStyle = value;
            return target;
        }

        public static T HeadersVisibility<T>(this T target, DataGridHeadersVisibility value) where T : DataGrid
        {
            target.HeadersVisibility = value;
            return target;
        }

        public static T AreRowDetailsFrozen<T>(this T target, bool value) where T : DataGrid
        {
            target.AreRowDetailsFrozen = value;
            return target;
        }

        public static T AlternatingRowBackground<T>(this T target, Brush value) where T : DataGrid
        {
            target.AlternatingRowBackground = value;
            return target;
        }

        public static T RowBackground<T>(this T target, Brush value) where T : DataGrid
        {
            target.RowBackground = value;
            return target;
        }

        public static T RowStyleSelector<T>(this T target, StyleSelector value) where T : DataGrid
        {
            target.RowStyleSelector = value;
            return target;
        }

        public static T RowValidationErrorTemplate<T>(this T target, ControlTemplate value) where T : DataGrid
        {
            target.RowValidationErrorTemplate = value;
            return target;
        }

        public static T VerticalGridLinesBrush<T>(this T target, Brush value) where T : DataGrid
        {
            target.VerticalGridLinesBrush = value;
            return target;
        }

        public static T HorizontalGridLinesBrush<T>(this T target, Brush value) where T : DataGrid
        {
            target.HorizontalGridLinesBrush = value;
            return target;
        }

        public static T GridLinesVisibility<T>(this T target, DataGridGridLinesVisibility value) where T : DataGrid
        {
            target.GridLinesVisibility = value;
            return target;
        }

        public static T MaxColumnWidth<T>(this T target, double value) where T : DataGrid
        {
            target.MaxColumnWidth = value;
            return target;
        }

        public static T MinColumnWidth<T>(this T target, double value) where T : DataGrid
        {
            target.MinColumnWidth = value;
            return target;
        }

        public static T ColumnWidth<T>(this T target, DataGridLength value) where T : DataGrid
        {
            target.ColumnWidth = value;
            return target;
        }

        public static T CanUserResizeColumns<T>(this T target, bool value) where T : DataGrid
        {
            target.CanUserResizeColumns = value;
            return target;
        }

        public static T RowHeaderWidth<T>(this T target, double value) where T : DataGrid
        {
            target.RowHeaderWidth = value;
            return target;
        }

        public static T ColumnHeaderHeight<T>(this T target, double value) where T : DataGrid
        {
            target.ColumnHeaderHeight = value;
            return target;
        }

        public static T CellStyle<T>(this T target, Style value) where T : DataGrid
        {
            target.CellStyle = value;
            return target;
        }

        public static T RowDetailsTemplate<T>(this T target, DataTemplate value) where T : DataGrid
        {
            target.RowDetailsTemplate = value;
            return target;
        }

        public static T MinRowHeight<T>(this T target, double value) where T : DataGrid
        {
            target.MinRowHeight = value;
            return target;
        }

        public static T CanUserResizeRows<T>(this T target, bool value) where T : DataGrid
        {
            target.CanUserResizeRows = value;
            return target;
        }

        public static T RowHeight<T>(this T target, double value) where T : DataGrid
        {
            target.RowHeight = value;
            return target;
        }

        public static T RowDetailsTemplateSelector<T>(this T target, DataTemplateSelector value) where T : DataGrid
        {
            target.RowDetailsTemplateSelector = value;
            return target;
        }

        public static T ClipboardCopyMode<T>(this T target, DataGridClipboardCopyMode value) where T : DataGrid
        {
            target.ClipboardCopyMode = value;
            return target;
        }

        public static T DropLocationIndicatorStyle<T>(this T target, Style value) where T : DataGrid
        {
            target.DropLocationIndicatorStyle = value;
            return target;
        }

        public static T CanUserReorderColumns<T>(this T target, bool value) where T : DataGrid
        {
            target.CanUserReorderColumns = value;
            return target;
        }

        public static T EnableColumnVirtualization<T>(this T target, bool value) where T : DataGrid
        {
            target.EnableColumnVirtualization = value;
            return target;
        }

        public static T EnableRowVirtualization<T>(this T target, bool value) where T : DataGrid
        {
            target.EnableRowVirtualization = value;
            return target;
        }

        public static T DragIndicatorStyle<T>(this T target, Style value) where T : DataGrid
        {
            target.DragIndicatorStyle = value;
            return target;
        }

        public static T FrozenColumnCount<T>(this T target, int value) where T : DataGrid
        {
            target.FrozenColumnCount = value;
            return target;
        }

        public static T AutoGenerateColumns<T>(this T target, bool value) where T : DataGrid
        {
            target.AutoGenerateColumns = value;
            return target;
        }

        public static T CanUserSortColumns<T>(this T target, bool value) where T : DataGrid
        {
            target.CanUserSortColumns = value;
            return target;
        }

        public static T SelectionUnit<T>(this T target, DataGridSelectionUnit value) where T : DataGrid
        {
            target.SelectionUnit = value;
            return target;
        }

        public static T SelectionMode<T>(this T target, DataGridSelectionMode value) where T : DataGrid
        {
            target.SelectionMode = value;
            return target;
        }

        public static T Columns<T>(this T target, IEnumerable<DataGridColumn> columns) where T : DataGrid
        {
            target.Columns.Clear();
            foreach (var column in columns)
            { 
                target.Columns.Add(column); 
            }

            return target;
        }
    }
}
