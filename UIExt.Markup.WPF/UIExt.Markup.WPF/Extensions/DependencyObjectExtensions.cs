using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class DependencyObjectExtensions
    {
        public static T CanContentScroll<T>(this T target, bool value) where T : DependencyObject
        {
            Controls.ScrollViewer.SetCanContentScroll(target, value);
            return target;
        }

        public static T HorizontalScrollBarVisibility<T>(this T target, ScrollBarVisibility value) where T : DependencyObject
        {
            Controls.ScrollViewer.SetHorizontalScrollBarVisibility(target, value);
            return target;
        }

        public static T IsDeferredScrollingEnabled<T>(this T target, bool value) where T : DependencyObject
        {
            Controls.ScrollViewer.SetIsDeferredScrollingEnabled(target, value);
            return target;
        }

        public static T PanningDeceleration<T>(this T target, double value) where T : DependencyObject
        {
            Controls.ScrollViewer.SetPanningDeceleration(target, value);
            return target;
        }

        public static T PanningMode<T>(this T target, PanningMode value) where T : DependencyObject
        {
            Controls.ScrollViewer.SetPanningMode(target, value);
            return target;
        }

        public static T PanningRatio<T>(this T target, double value) where T : DependencyObject
        {
            Controls.ScrollViewer.SetPanningRatio(target, value);
            return target;
        }

        public static T VerticalScrollBarVisibility<T>(this T target, ScrollBarVisibility value) where T : DependencyObject
        {
            Controls.ScrollViewer.SetVerticalScrollBarVisibility(target, value);
            return target;
        }

        public static T OverflowMode<T>(this T target, OverflowMode value) where T : DependencyObject
        {
            Controls.ToolBar.SetOverflowMode(target, value);
            return target;
        }

        public static T SetIsSelected<T>(this T target, bool value) where T : DependencyObject
        {
            Controls.Primitives.Selector.SetIsSelected(target, value);
            return target;
        }

        public static T AddSelectedHandler<T>(this T target, RoutedEventHandler value) where T : DependencyObject
        {
            Controls.Primitives.Selector.AddSelectedHandler(target, value);
            return target;
        }

        public static T AddUnselectedHandler<T>(this T target, RoutedEventHandler value) where T : DependencyObject
        {
            Controls.Primitives.Selector.AddUnselectedHandler(target, value);
            return target;
        }

        public static T RemoveSelectedHandler<T>(this T target, RoutedEventHandler value) where T : DependencyObject
        {
            Controls.Primitives.Selector.RemoveSelectedHandler(target, value);
            return target;
        }

        public static T RemoveUnselectedHandler<T>(this T target, RoutedEventHandler value) where T : DependencyObject
        {
            Controls.Primitives.Selector.RemoveUnselectedHandler(target, value);
            return target;
        }
    }
}
