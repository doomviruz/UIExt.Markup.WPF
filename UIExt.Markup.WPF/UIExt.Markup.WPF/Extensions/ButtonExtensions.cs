using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace System.Windows
{
    public static class ButtonExtensions
    {
        public static T OnClick<T>(this T control, RoutedEventHandler handler) where T : ButtonBase
        {
            control.Click += handler;
            return control;
        }

        public static T Command<T>(this T source, ICommand command) where T : ButtonBase
        {
            source.Command = command;
            return source;
        }

    }
}
