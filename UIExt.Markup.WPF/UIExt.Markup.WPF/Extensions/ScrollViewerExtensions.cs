using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class ScrollViewerExtensions
    {
        public static ScrollViewer CanContentScroll(this ScrollViewer target, bool value)
        {
            target.CanContentScroll = value;
            return target;
        }

        public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer target, ScrollBarVisibility value)
        {
            target.HorizontalScrollBarVisibility = value;
            return target;
        }

        public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer target, ScrollBarVisibility value)
        {
            target.VerticalScrollBarVisibility = value;
            return target;
        }

        public static ScrollViewer PanningDeceleration(this ScrollViewer target, double value)
        {
            target.PanningDeceleration = value;
            return target;
        }

        public static ScrollViewer IsDeferredScrollingEnabled(this ScrollViewer target, bool value)
        {
            target.IsDeferredScrollingEnabled = value;
            return target;
        }

        public static ScrollViewer PanningMode(this ScrollViewer target, PanningMode value) 
        {
            target.PanningMode = value;
            return target;
        }

        public static ScrollViewer PanningRatio(this ScrollViewer target, double value)
        {
            target.PanningRatio = value;
            return target;
        }
    }
}
