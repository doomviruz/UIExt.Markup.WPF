﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class VirtualizingStackPanelExtensions
    {
        public static T Orientation<T>(this T target, Orientation value) where T : VirtualizingStackPanel
        {
            target.Orientation = value;
            return target;
        }

        public static T ScrollOwner<T>(this T target, ScrollViewer value) where T : VirtualizingStackPanel
        {
            target.ScrollOwner = value;
            return target;
        }
    }
}
