using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace System.Windows
{
    public static class ToggleButtonExtensions
    {
        public static T IsChecked<T>(this T target, bool? value) where T : ToggleButton
        {
            target.IsChecked = value;
            return target;
        }

        public static T IsThreeState<T>(this T target, bool value) where T : ToggleButton
        {
            target.IsThreeState = value;
            return target;
        }

        public static T OnChecked<T>(this T target, RoutedEventHandler handler) where T : ToggleButton
        {
            target.Checked += handler;
            return target;
        }

        public static T OnUnchecked<T>(this T target, RoutedEventHandler handler) where T : ToggleButton
        {
            target.Unchecked += handler;
            return target;
        }

        public static T OnIndeterminate<T>(this T target, RoutedEventHandler handler) where T : ToggleButton
        {
            target.Indeterminate += handler;
            return target;
        }
    }
}
