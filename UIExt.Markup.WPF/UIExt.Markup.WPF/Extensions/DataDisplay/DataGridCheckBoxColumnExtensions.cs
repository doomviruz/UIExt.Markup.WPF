using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace System.Windows
{
    public static class DataGridCheckBoxColumnExtensions
    {
        public static T IsThreeState<T>(this T target, bool value) where T : DataGridCheckBoxColumn
        {
            target.IsThreeState = value;
            return target;
        }
    }
}
