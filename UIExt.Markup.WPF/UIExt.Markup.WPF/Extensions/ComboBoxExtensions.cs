using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace System.Windows
{
    public static class ComboBoxExtensions
    {
        public static T ShouldPreserveUserEnteredPrefix<T>(this T target, bool value) where T : ComboBox
        {
            target.ShouldPreserveUserEnteredPrefix = value;
            return target;
        }

        public static T IsEditable<T>(this T target, bool value) where T : ComboBox
        {
            target.IsEditable = value;
            return target;
        }

        public static T IsReadOnly<T>(this T target, bool value) where T : ComboBox
        {
            target.IsReadOnly = value;
            return target;
        }

        public static T Text<T>(this T target, string value) where T : ComboBox
        {
            target.Text = value;
            return target;
        }

        public static T MaxDropDownHeight<T>(this T target, double value) where T : ComboBox
        {
            target.MaxDropDownHeight = value;
            return target;
        }

        public static T StaysOpenOnEdit<T>(this T target, bool value) where T : ComboBox
        {
            target.StaysOpenOnEdit = value;
            return target;
        }

        public static T IsDropDownOpen<T>(this T target, bool value) where T : ComboBox
        {
            target.IsDropDownOpen = value;
            return target;
        }
    }
}
