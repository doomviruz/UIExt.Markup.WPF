using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class RangeBaseExtensions
    {
        public static T LargeChange<T>(this T target, double value) where T : RangeBase
        {
            target.LargeChange = value;
            return target;
        }

        public static T SmallChange<T>(this T target, double value) where T : RangeBase
        {
            target.SmallChange = value;
            return target;
        }

        public static T Value<T>(this T target, double value) where T : RangeBase
        {
            target.Value = value;
            return target;
        }

        public static T Maximum<T>(this T target, double value) where T : RangeBase
        {
            target.Maximum = value;
            return target;
        }

        public static T Minimum<T>(this T target, double value) where T : RangeBase
        {
            target.Minimum = value;
            return target;
        }
    }
}
