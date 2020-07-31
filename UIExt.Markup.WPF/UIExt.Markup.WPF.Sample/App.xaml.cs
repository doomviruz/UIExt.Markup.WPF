using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using UIExt.Markup.WPF.Sample;

namespace WPF.Sample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var dialog = new SampleDialog(new SampleDialogViewModel())
            {
                WindowStyle = WindowStyle.None,
                SizeToContent = SizeToContent.Height,
                ResizeMode = ResizeMode.NoResize,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Title = "",
            }
            .BorderBrush(Brushes.LightGray)
            .Border(1)
            .Height(550)
            .Width(600);

            MainWindow = dialog;
            dialog.Show();
        }
    }
}
