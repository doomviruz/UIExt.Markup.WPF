using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class DockPanelExtensions
    {
        public static T LastChildFill<T>(this T target, bool value) where T : DockPanel
        {
            target.LastChildFill = value;
            return target;
        }
    }
}
