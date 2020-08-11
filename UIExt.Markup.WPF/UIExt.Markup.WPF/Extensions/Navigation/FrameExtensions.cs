using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace System.Windows
{
    public static class FrameExtensions
    {
        public static T NavigationUIVisibility<T>(this T source, NavigationUIVisibility value) where T : Frame
        {
            source.NavigationUIVisibility = value;
            return source;
        }

        public static T JournalOwnership<T>(this T source, JournalOwnership value) where T : Frame
        {
            source.JournalOwnership = value;
            return source;
        }

        public static T SandboxExternalContent<T>(this T source, bool value) where T : Frame
        {
            source.SandboxExternalContent = value;
            return source;
        }

        public static T Source<T>(this T source, Uri value) where T : Frame
        {
            source.Source = value;
            return source;
        }
    }
}
