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
    public static class ScrollbarExtensions
    {
        public static T Orientation<T>(this T target, Orientation value) where T : ScrollBar
        {
            target.Orientation = value;
            return target;
        }

        public static T ViewportSize<T>(this T target, double value) where T : ScrollBar
        {
            target.ViewportSize = value;
            return target;
        }
    }
}
