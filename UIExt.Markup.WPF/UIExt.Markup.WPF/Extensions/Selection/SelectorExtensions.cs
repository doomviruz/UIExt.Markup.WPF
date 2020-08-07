using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace System.Windows
{
    public static class SelectorExtensions
    {
        public static T SelectedValue<T>(this T target, object value) where T : Selector
        {
            target.SelectedValue = value;
            return target;
        }

        public static T SelectedItem<T>(this T target, object value) where T : Selector
        {
            target.SelectedItem = value;
            return target;
        }

        public static T SelectedIndex<T>(this T target, int value) where T : Selector
        {
            target.SelectedIndex = value;
            return target;
        }

        public static T IsSynchronizedWithCurrentItem<T>(this T target, bool? value) where T : Selector
        {
            target.IsSynchronizedWithCurrentItem = value;
            return target;
        }

        public static T SelectedValuePath<T>(this T target, string value) where T : Selector
        {
            target.SelectedValuePath = value;
            return target;
        }
    }
}
