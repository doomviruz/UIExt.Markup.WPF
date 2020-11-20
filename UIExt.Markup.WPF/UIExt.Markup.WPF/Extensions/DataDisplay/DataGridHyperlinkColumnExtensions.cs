using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace System.Windows
{
    public static class DataGridHyperlinkColumnExtensions
    {
        public static T TargetName<T>(this T target, string value) where T : DataGridHyperlinkColumn
        {
            target.TargetName = value;
            return target;
        }

        public static T ContentBinding<T>(this T target, BindingBase value) where T : DataGridHyperlinkColumn
        {
            target.ContentBinding = value;
            return target;
        }
    }
}
