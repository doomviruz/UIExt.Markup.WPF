using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.Sample;

namespace UIExt.Markup.WPF.Sample
{
    public class SampleDialogViewModel : INotifyPropertyChanged
    {
        private bool _additionalTextVisible;
        public SampleDialogViewModel()
        {
            ToggleTextVisibilityCommand = new ActionCommand(() => AdditionalTextVisible = !AdditionalTextVisible);
            ActionCommand = new ActionCommand(() => MessageBox.Show("Action invoked"));
            ExitCommand = new ActionCommand(() => App.Current.Shutdown());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ActionCommand ToggleTextVisibilityCommand { get; }

        public ActionCommand ActionCommand { get; }

        public ActionCommand ExitCommand { get; }

        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool AdditionalTextVisible
        {
            get => _additionalTextVisible;

            set
            {
                _additionalTextVisible = value;
                OnPropertyChanged();
            }
        }
    }
}
