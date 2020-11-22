using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace System.Windows
{
    public static class ListViewExtensions
    {
        public static T RowHeaderTemplate<T>(this T target, ViewBase value) where T : ListView
        {
            target.View = value;
            return target;
        }
    }
}
