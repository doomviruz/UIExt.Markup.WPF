using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class ExpanderExtensions
    {
        public static T ExpandDirection<T>(this T target, ExpandDirection value) where T : Expander
        {
            target.ExpandDirection = value;
            return target;
        }

        public static T IsExpanded<T>(this T target, bool value) where T : Expander
        {
            target.IsExpanded = value;
            return target;
        }
    }
}
