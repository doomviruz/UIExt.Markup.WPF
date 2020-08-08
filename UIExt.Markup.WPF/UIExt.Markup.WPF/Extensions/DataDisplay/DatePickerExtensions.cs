using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace System.Windows
{
    public static class DatePickerExtensions
    {
        public static T DisplayDateStart<T>(this T source, DateTime? value) where T : DatePicker
        {
            source.DisplayDateStart = value;
            return source;
        }

        public static T CalendarStyle<T>(this T source, Style value) where T : DatePicker
        {
            source.CalendarStyle = value;
            return source;
        }

        public static T DisplayDateEnd<T>(this T source, DateTime? value) where T : DatePicker
        {
            source.DisplayDateEnd = value;
            return source;
        }

        public static T IsTodayHighlighted<T>(this T source, bool value) where T : DatePicker
        {
            source.IsTodayHighlighted = value;
            return source;
        }

        public static T IsDropDownOpen<T>(this T source, bool value) where T : DatePicker
        {
            source.IsDropDownOpen = value;
            return source;
        }

        public static T SelectedDate<T>(this T source, DateTime? value) where T : DatePicker
        {
            source.SelectedDate = value;
            return source;
        }

        public static T SelectedDateFormat<T>(this T source, DatePickerFormat value) where T : DatePicker
        {
            source.SelectedDateFormat = value;
            return source;
        }

        public static T Text<T>(this T source, string value) where T : DatePicker
        {
            source.Text = value;
            return source;
        }

        public static T DisplayDate<T>(this T source, DateTime value) where T : DatePicker
        {
            source.DisplayDate = value;
            return source;
        }

        public static T FirstDayOfWeek<T>(this T source, DayOfWeek value) where T : DatePicker
        {
            source.FirstDayOfWeek = value;
            return source;
        }
    }
}
