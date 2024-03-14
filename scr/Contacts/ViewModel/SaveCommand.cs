using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Contacts.Model;
using Contacts.Model.Services;

namespace Contacts.ViewModel
{
    internal class SaveCommand : ICommand
    {
        public readonly Action<object> _executeAction;

        public event EventHandler CanExecuteChanged;

        public SaveCommand(Action<object> excutionAction)
        {
            _executeAction = excutionAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Contact contact = new Contact();
            //ContactSerializer.SaveToFile(MainVM.GetInfo());
            ContactSerializer.SaveToFile(new Contact("Name","Phone","Email"));
        }

        //public event EventHandler CanExecuteChanged
        //{
        //    add
        //    {
        //        CommandManager.RequerySuggested += value;
        //    }
        //    remove
        //    {
        //        CommandManager.RequerySuggested -= value;
        //    }
        //}
    }
}
