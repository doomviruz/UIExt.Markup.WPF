using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static UIExt.Markup.WPF.UIExt;

namespace System.Windows
{
    public static class HeaderedContentControlExtensions
    {
        public static T HeaderTemplateSelector<T>(this T target, DataTemplateSelector value) where T : HeaderedContentControl
        {
            target.HeaderTemplateSelector = value;
            return target;
        }

        public static T HeaderTemplate<T>(this T target, DataTemplate value) where T : HeaderedContentControl
        {
            target.HeaderTemplate = value;
            return target;
        }

        public static T HeaderStringFormat<T>(this T target, string value) where T : HeaderedContentControl
        {
            target.HeaderStringFormat = value;
            return target;
        }

        public static T Header<T>(this T target, object value) where T : HeaderedContentControl
        {
            target.Header = value;
            return target;
        }
    }
}
