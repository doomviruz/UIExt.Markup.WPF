using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace System.Windows
{
    public static class RepeatButtonExtensions
    {
        public static T Delay<T>(this T source, int value) where T : RepeatButton
        {
            source.Delay = value;
            return source;
        }

        public static T Interval<T>(this T source, int value) where T : RepeatButton
        {
            source.Interval = value;
            return source;
        }
    }
}
