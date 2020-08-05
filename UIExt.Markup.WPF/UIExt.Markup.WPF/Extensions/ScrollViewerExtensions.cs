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
        public static T CanContentScroll<T>(this T target, bool value) where T : ScrollViewer
        {
            target.CanContentScroll = value;
            return target;
        }

        public static T HorizontalScrollBarVisibility<T>(this T target, ScrollBarVisibility value) where T : ScrollViewer
        {
            target.HorizontalScrollBarVisibility = value;
            return target;
        }

        public static T VerticalScrollBarVisibility<T>(this T target, ScrollBarVisibility value) where T : ScrollViewer
        {
            target.VerticalScrollBarVisibility = value;
            return target;
        }

        public static T PanningDeceleration<T>(this T target, double value) where T : ScrollViewer
        {
            target.PanningDeceleration = value;
            return target;
        }

        public static T IsDeferredScrollingEnabled<T>(this T target, bool value) where T : ScrollViewer
        {
            target.IsDeferredScrollingEnabled = value;
            return target;
        }

        public static T PanningMode<T>(this T target, PanningMode value) where T : ScrollViewer
        {
            target.PanningMode = value;
            return target;
        }

        public static T PanningRatio<T>(this T target, double value) where T : ScrollViewer
        {
            target.PanningRatio = value;
            return target;
        }
    }
}
