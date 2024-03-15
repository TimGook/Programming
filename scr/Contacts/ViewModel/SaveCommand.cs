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
    /// <summary>
    /// Команда для сохранения данных контакта.
    /// </summary>
    internal class SaveCommand : ICommand
    {
        /// <summary>
        /// Хранит ссылку на метод сохранения.
        /// </summary>
        public readonly Action<object> _executeAction;

        /// <summary>
        /// Создаёт экземпляр команды <see cref="SaveCommand"/>
        /// </summary>
        /// <param name="excutionAction">Метод сохранения.</param>
        public SaveCommand(Action<object> excutionAction)
        {
            _executeAction = excutionAction;
        }

        /// <summary>
        /// Сообщает, не отключена ли команда.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>True, если команда доступна. False, если команда недоступна.</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Хранит логику сохранения.
        /// </summary>
        /// <param name="parameter">Сохраняемый контакт.</param>
        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }

        /// <summary>
        /// Вызывается при изменении состояния команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
    }
}
