using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class GridSplitterExtensions
    {
        public static T PreviewStyle<T>(this T target, Style value) where T : GridSplitter
        {
            target.PreviewStyle = value;
            return target;
        }

        public static T ShowsPreview<T>(this T target, bool value) where T : GridSplitter
        {
            target.ShowsPreview = value;
            return target;
        }

        public static T ResizeBehavior<T>(this T target, GridResizeBehavior value) where T : GridSplitter
        {
            target.ResizeBehavior = value;
            return target;
        }

        public static T ResizeDirection<T>(this T target, GridResizeDirection value) where T : GridSplitter
        {
            target.ResizeDirection = value;
            return target;
        }

        public static T DragIncrement<T>(this T target, double value) where T : GridSplitter
        {
            target.DragIncrement = value;
            return target;
        }

        public static T KeyboardIncrement<T>(this T target, double value) where T : GridSplitter
        {
            target.KeyboardIncrement = value;
            return target;
        }
    }
}
