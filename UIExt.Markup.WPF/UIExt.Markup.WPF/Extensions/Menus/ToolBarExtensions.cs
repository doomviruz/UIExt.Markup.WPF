using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace System.Windows
{
    public static class ToolBarExtensions
    {
        public static T Band<T>(this T source, int value) where T : ToolBar
        {
            source.Band = value;
            return source;
        }

        public static T BandIndex<T>(this T source, int value) where T : ToolBar
        {
            source.BandIndex = value;
            return source;
        }

        public static T IsOverflowOpen<T>(this T source, bool value) where T : ToolBar
        {
            source.IsOverflowOpen = value;
            return source;
        }
    }
}
