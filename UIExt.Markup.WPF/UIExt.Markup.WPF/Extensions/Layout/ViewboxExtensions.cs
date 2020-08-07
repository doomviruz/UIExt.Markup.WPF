using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class ViewboxExtensions
    {
        public static T Child<T>(this T target, UIElement value) where T : Viewbox
        {
            target.Child = value;
            return target;
        }

        public static T Stretch<T>(this T target, Stretch value) where T : Viewbox
        {
            target.Stretch = value;
            return target;
        }

        public static T StretchDirection<T>(this T target, StretchDirection value) where T : Viewbox
        {
            target.StretchDirection = value;
            return target;
        }
    }
}
