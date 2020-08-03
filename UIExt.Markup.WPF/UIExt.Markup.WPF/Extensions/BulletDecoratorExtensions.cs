using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class BulletDecoratorExtensions
    {
        public static T Background<T>(this T target, Brush value) where T : BulletDecorator
        {
            target.Background = value;
            return target;
        }

        public static T Bullet<T>(this T target, UIElement value) where T : BulletDecorator
        {
            target.Bullet = value;
            return target;
        }
    }
}
