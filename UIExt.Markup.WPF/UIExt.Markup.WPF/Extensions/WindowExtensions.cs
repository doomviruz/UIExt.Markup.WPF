using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Shell;
using System.Windows.Media;

namespace System.Windows
{
    public static class WindowExtensions
    {
        public static T ShowInTaskbar<T>(this T target, bool value) where T : Window
        {
            target.ShowInTaskbar = value;
            return target;
        }

        public static T StartupLocation<T>(this T target, WindowStartupLocation value) where T : Window
        {
            target.WindowStartupLocation = value;
            return target;
        }

        public static T TaskbarItemInfo<T>(this T target, TaskbarItemInfo value) where T : Window
        {
            target.TaskbarItemInfo = value;
            return target;
        }

        public static T Top<T>(this T target, double value) where T : Window
        {
            target.Top = value;
            return target;
        }

        public static T SizeToContent<T>(this T target, SizeToContent value) where T : Window
        {
            target.SizeToContent = value;
            return target;
        }

        public static T AllowsTransparency<T>(this T target, bool value) where T : Window
        {
            target.AllowsTransparency = value;
            return target;
        }

        public static T Owner<T>(this T target, Window value) where T : Window
        {
            target.Owner = value;
            return target;
        }

        public static T Left<T>(this T target, double value) where T : Window
        {
            target.Left = value;
            return target;
        }

        public static T Icon<T>(this T target, ImageSource value) where T : Window
        {
            target.Icon = value;
            return target;
        }

        public static T WindowStyle<T>(this T target, WindowStyle value) where T : Window
        {
            target.WindowStyle = value;
            return target;
        }

        public static T State<T>(this T target, WindowState value) where T : Window
        {
            target.WindowState = value;
            return target;
        }

        public static T ResizeMode<T>(this T target, ResizeMode value) where T : Window
        {
            target.ResizeMode = value;
            return target;
        }

        public static T Topmost<T>(this T target, bool value) where T : Window
        {
            target.Topmost = value;
            return target;
        }

        public static T ShowActivated<T>(this T target, bool value) where T : Window
        {
            target.ShowActivated = value;
            return target;
        }

        public static T Title<T>(this T target, string value) where T : Window
        {
            target.Title = value;
            return target;
        }
    }
}
