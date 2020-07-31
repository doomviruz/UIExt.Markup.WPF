using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using UIExt.Markup.WPF;

namespace System.Windows
{
    public static class StyleExtensions
    {
        public static T Prop<T>(this T target, DependencyProperty property) where T : Setter
        {
            target.Property = property;
            return target;
        }

        public static T Value<T>(this T target, object value) where T : Setter
        {
            target.Value = value;
            return target;
        }

        public static T Target<T>(this T target, string targetName) where T : Setter
        {
            target.TargetName = targetName;
            return target;
        }

        public static Element<T> SetPropValue<T>(this Element<T> target, DependencyProperty property, object value) where T : UIElement
        {
            target.Factory.SetValue(property, value);
            return target;
        }

        public static Element<TParent> Childs<TParent>(this Element<TParent> target, params Element[] childs)
            where TParent : UIElement
        {
            foreach (var child in childs)
            {
                target.AppendChild(child);
            }

            return target;
        }

        public static Element<T> Background<T>(this Element<T> target, Brush value) where T : Control =>
            target.SetPropValue(Control.BackgroundProperty, value);

        public static Element<T> Background<T>(this Element<T> target, object value) where T : Control =>
            target.SetPropValue(Control.BackgroundProperty, value);

        public static Element<Border> Background(this Element<Border> target, Brush value) =>
            target.SetPropValue(Border.BackgroundProperty, value);

        public static Element<Border> Background(this Element<Border> target, object value) =>
            target.SetPropValue(Border.BackgroundProperty, value);

        public static Element<Border> BorderBrush(this Element<Border> target, Brush value) =>
            target.SetPropValue(Border.BorderBrushProperty, value);

        public static Element<Border> BorderBrush(this Element<Border> target, object value) =>
            target.SetPropValue(Border.BorderBrushProperty, value);

        public static Element<Border> BorderThickness(this Element<Border> target, double value) =>
            target.SetPropValue(Border.BorderThicknessProperty, new Thickness(value));

        public static Element<Border> BorderThickness(this Element<Border> target, object value) =>
            target.SetPropValue(Border.BorderThicknessProperty, value);

        public static Style Triggers(this Style target, params TriggerBase[] triggers)
        {
            target.Triggers.Clear();
            foreach (var trigger in triggers)
            {
                target.Triggers.Add(trigger);
            }

            return target;
        }

        public static Style Setters(this Style target, params SetterBase[] setters)
        {
            target.Triggers.Clear();
            foreach (var setter in setters)
            {
                target.Setters.Add(setter);
            }

            return target;
        }
    }
}
