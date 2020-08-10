using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace System.Windows
{
    public static class ListBoxExtensions
    {
        public static T SelectionMode<T>(this T target, SelectionMode value) where T : ListBox
        {
            target.SelectionMode = value;
            return target;
        }
    }
}
