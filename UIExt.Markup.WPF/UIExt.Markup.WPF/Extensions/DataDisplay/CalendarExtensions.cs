using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace System.Windows
{
    public static class CalendarExtensions
    {
        public static T DisplayDateStart<T>(this T source, DateTime? value) where T : Calendar
        {
            source.DisplayDateStart = value;
            return source;
        }

        public static T ItemStyle<T>(this T source, Style value) where T : Calendar
        {
            source.CalendarItemStyle = value;
            return source;
        }

        public static T DayButtonStyle<T>(this T source, Style value) where T : Calendar
        {
            source.CalendarDayButtonStyle = value;
            return source;
        }

        public static T ButtonStyle<T>(this T source, Style value) where T : Calendar
        {
            source.CalendarButtonStyle = value;
            return source;
        }

        public static T DisplayMode<T>(this T source, CalendarMode value) where T : Calendar
        {
            source.DisplayMode = value;
            return source;
        }

        public static T DisplayDateEnd<T>(this T source, DateTime? value) where T : Calendar
        {
            source.DisplayDateEnd = value;
            return source;
        }

        public static T IsTodayHighlighted<T>(this T source, bool value) where T : Calendar
        {
            source.IsTodayHighlighted = value;
            return source;
        }

        public static T SelectedDate<T>(this T source, DateTime? value) where T : Calendar
        {
            source.SelectedDate = value;
            return source;
        }

        public static T SelectionMode<T>(this T source, CalendarSelectionMode value) where T : Calendar
        {
            source.SelectionMode = value;
            return source;
        }

        public static T DisplayDate<T>(this T source, DateTime value) where T : Calendar
        {
            source.DisplayDate = value;
            return source;
        }

        public static T FirstDayOfWeek<T>(this T source, DayOfWeek value) where T : Calendar
        {
            source.FirstDayOfWeek = value;
            return source;
        }
    }
}
