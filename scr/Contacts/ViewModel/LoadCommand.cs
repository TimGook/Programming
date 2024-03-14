using Contacts.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Contacts.Model;

namespace Contacts.ViewModel
{
    internal class LoadCommand : ICommand
    {
        public readonly Action<object> _executeAction;

        public event EventHandler CanExecuteChanged;

        public LoadCommand(Action<object> excutionAction)
        {
            _executeAction = excutionAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Contact contact = ContactSerializer.LoadFromFile();

        }
    }
}
