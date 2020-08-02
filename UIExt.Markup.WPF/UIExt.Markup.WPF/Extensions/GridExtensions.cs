using System.Windows.Controls;

namespace System.Windows
{
    public static class GridExtensions
    {
        public static RowDefinition Height(this RowDefinition target, double height)
        {
            target.Height = new GridLength(height);
            return target;
        }

        public static RowDefinition StarHeight(this RowDefinition target, double stars)
        {
            target.Height = new GridLength(stars, GridUnitType.Star);
            return target;
        }

        public static RowDefinition HeightAll(this RowDefinition target)
        {
            target.Height = new GridLength(1, GridUnitType.Star);
            return target;
        }

        public static RowDefinition HeightAuto(this RowDefinition target)
        {
            target.Height = new GridLength(0, GridUnitType.Auto);
            return target;
        }

        public static ColumnDefinition Width(this ColumnDefinition target, double height)
        {
            target.Width = new GridLength(height);
            return target;
        }

        public static ColumnDefinition WidthAuto(this ColumnDefinition target)
        {
            target.Width = new GridLength(0, GridUnitType.Auto);
            return target;
        }

        public static ColumnDefinition WidthAll(this ColumnDefinition target)
        {
            target.Width = new GridLength(1, GridUnitType.Star);
            return target;
        }

        public static ColumnDefinition StarWidth(this ColumnDefinition target, double stars)
        {
            target.Width = new GridLength(stars, GridUnitType.Star);
            return target;
        }

        public static T RowDefs<T>(this T target, params RowDefinition[] rows) where T : Grid
        {
            target.RowDefinitions.Clear();
            foreach (var row in rows)
            {
                target.RowDefinitions.Add(row);
            }

            return target;
        }

        public static T ColDefs<T>(this T target, params ColumnDefinition[] columns) where T : Grid
        {
            target.ColumnDefinitions.Clear();
            foreach (var column in columns)
            {
                target.ColumnDefinitions.Add(column);
            }

            return target;
        }

        public static T ShowGridLines<T>(this T target, bool value) where T : Grid
        {
            target.ShowGridLines = value;
            return target;
        }
    }
}
