using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;

namespace System.Windows
{
    public static class ItemsControlExtensions
    {
        public static T AlternationCount<T>(this T target, int value) where T : ItemsControl
        {
            target.AlternationCount = value;
            return target;
        }

        public static T GroupStyleSelector<T>(this T target, GroupStyleSelector value) where T : ItemsControl
        {
            target.GroupStyleSelector = value;
            return target;
        }

        public static T ItemsPanel<T>(this T target, ItemsPanelTemplate value) where T : ItemsControl
        {
            target.ItemsPanel = value;
            return target;
        }

        public static T ItemContainerStyleSelector<T>(this T target, StyleSelector value) where T : ItemsControl
        {
            target.ItemContainerStyleSelector = value;
            return target;
        }

        public static T ItemContainerStyle<T>(this T target, Style value) where T : ItemsControl
        {
            target.ItemContainerStyle = value;
            return target;
        }

        public static T ItemBindingGroup<T>(this T target, BindingGroup value) where T : ItemsControl
        {
            target.ItemBindingGroup = value;
            return target;
        }

        public static T ItemStringFormat<T>(this T target, string value) where T : ItemsControl
        {
            target.ItemStringFormat = value;
            return target;
        }

        public static T ItemTemplateSelector<T>(this T target, DataTemplateSelector value) where T : ItemsControl
        {
            target.ItemTemplateSelector = value;
            return target;
        }

        public static T ItemTemplate<T>(this T target, DataTemplate value) where T : ItemsControl
        {
            target.ItemTemplate = value;
            return target;
        }

        public static T DisplayMemberPath<T>(this T target, string value) where T : ItemsControl
        {
            target.DisplayMemberPath = value;
            return target;
        }

        public static T ItemsSource<T>(this T target, IEnumerable value) where T : ItemsControl
        {
            target.ItemsSource = value;
            return target;
        }

        public static T IsTextSearchCaseSensitive<T>(this T target, bool value) where T : ItemsControl
        {
            target.IsTextSearchCaseSensitive = value;
            return target;
        }

        public static T IsTextSearchEnabled<T>(this T target, bool value) where T : ItemsControl
        {
            target.IsTextSearchEnabled = value;
            return target;
        }

    }
}
