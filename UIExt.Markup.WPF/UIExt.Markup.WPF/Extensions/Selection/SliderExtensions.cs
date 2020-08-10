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
    public static class SliderExtensions
    {
        public static T IsSnapToTickEnabled<T>(this T target, bool value) where T : Slider
        {
            target.IsSnapToTickEnabled = value;
            return target;
        }

        public static T AutoToolTipPrecision<T>(this T target, int value) where T : Slider
        {
            target.AutoToolTipPrecision = value;
            return target;
        }

        public static T AutoToolTipPlacement<T>(this T target, AutoToolTipPlacement value) where T : Slider
        {
            target.AutoToolTipPlacement = value;
            return target;
        }

        public static T Interval<T>(this T target, int value) where T : Slider
        {
            target.Interval = value;
            return target;
        }

        public static T Delay<T>(this T target, int value) where T : Slider
        {
            target.Delay = value;
            return target;
        }

        public static T IsDirectionReversed<T>(this T target, bool value) where T : Slider
        {
            target.IsDirectionReversed = value;
            return target;
        }

        public static T Orientation<T>(this T target, Orientation value) where T : Slider
        {
            target.Orientation = value;
            return target;
        }

        public static T TickFrequency<T>(this T target, double value) where T : Slider
        {
            target.TickFrequency = value;
            return target;
        }

        public static T Ticks<T>(this T target, DoubleCollection value) where T : Slider
        {
            target.Ticks = value;
            return target;
        }

        public static T SelectionStart<T>(this T target, double value) where T : Slider
        {
            target.SelectionStart = value;
            return target;
        }

        public static T TickPlacement<T>(this T target, TickPlacement value) where T : Slider
        {
            target.TickPlacement = value;
            return target;
        }

        public static T IsSelectionRangeEnabled<T>(this T target, bool value) where T : Slider
        {
            target.IsSelectionRangeEnabled = value;
            return target;
        }

        public static T IsMoveToPointEnabled<T>(this T target, bool value) where T : Slider
        {
            target.IsMoveToPointEnabled = value;
            return target;
        }

        public static T SelectionEnd<T>(this T target, double value) where T : Slider
        {
            target.SelectionEnd = value;
            return target;
        }
    }
}
