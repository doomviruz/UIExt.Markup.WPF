using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace UIExt.Markup.WPF
{
    public static class TriggerDefs
    {
        public static Trigger IsPressed(params Setter[] setters) =>
            UIExt.Trigger(ButtonBase.IsPressedProperty, true, setters);

        public static Trigger IsMouseOver(params Setter[] setters) =>
            UIExt.Trigger(UIElement.IsMouseOverProperty, true, setters);

        public static Trigger IsEnabled(params Setter[] setters) =>
            UIExt.Trigger(UIElement.IsEnabledProperty, true, setters);

        public static Trigger IsDisabled(params Setter[] setters) =>
            UIExt.Trigger(UIElement.IsEnabledProperty, false, setters);
    }
}
