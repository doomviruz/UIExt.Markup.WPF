using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace System.Windows
{
    public static class TreeViewExtensions
    {
        public static T SelectedValuePath<T>(this T target, string value) where T : TreeView
        {
            target.SelectedValuePath = value;
            return target;
        }
    }
}
