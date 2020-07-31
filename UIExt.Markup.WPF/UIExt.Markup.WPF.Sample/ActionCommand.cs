using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UIExt.Markup.WPF.Sample
{
    public class ActionCommand : ICommand
    {
        private readonly Action _action;

        public ActionCommand(Action action) => _action = action;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _action?.Invoke();
        }
    }
}
