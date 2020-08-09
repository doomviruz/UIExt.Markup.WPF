using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace System.Windows
{
    public static class MenuExtensions
    {
        public static T IsMainMenu<T>(this T source, bool value) where T : Menu
        {
            source.IsMainMenu = value;
            return source;
        }
    }
}
