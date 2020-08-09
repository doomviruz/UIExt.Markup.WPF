using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace System.Windows
{
    public static class MenuBaseExtensions
    {
        public static T ItemContainerTemplateSelector<T>(this T source, ItemContainerTemplateSelector value) where T : MenuBase
        {
            source.ItemContainerTemplateSelector = value;
            return source;
        }

        public static T UsesItemContainerTemplate<T>(this T source, bool value) where T : MenuBase
        {
            source.UsesItemContainerTemplate = value;
            return source;
        }
    }
}
