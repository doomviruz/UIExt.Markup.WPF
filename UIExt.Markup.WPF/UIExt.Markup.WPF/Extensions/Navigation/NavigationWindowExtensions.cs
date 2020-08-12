using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace System.Windows
{
    public static class NavigationWindowExtensions
    {
        public static T SandboxExternalContent<T>(this T source, bool value) where T : NavigationWindow
        {
            source.SandboxExternalContent = value;
            return source;
        }
    }
}
