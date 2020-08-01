using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace System.Windows
{
    public static class RadioButtonExtensions
    {
        public static T Group<T>(this T target, string value) where T : RadioButton
        {
            target.GroupName = value;
            return target;
        }
    }
}
