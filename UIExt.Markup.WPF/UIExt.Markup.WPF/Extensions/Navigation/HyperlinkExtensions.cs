using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace System.Windows
{
    public static class HyperlinkExtensions
    {
        public static T TargetName<T>(this T source, string value) where T : Hyperlink
        {
            source.TargetName = value;
            return source;
        }

        public static T NavigateUri<T>(this T source, Uri value) where T : Hyperlink
        {
            source.NavigateUri = value;
            return source;
        }

        public static T CommandTarget<T>(this T source, IInputElement value) where T : Hyperlink
        {
            source.CommandTarget = value;
            return source;
        }

        public static T CommandParameter<T>(this T source, object value) where T : Hyperlink
        {
            source.CommandParameter = value;
            return source;
        }

        public static T Command<T>(this T source, ICommand value) where T : Hyperlink
        {
            source.Command = value;
            return source;
        }
    }
}
