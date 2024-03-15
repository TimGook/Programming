using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Команда для сохранения и загрузки контакта.
    /// </summary>
    class RelayCommand : ICommand
    {
        /// <summary>
        /// Хранит ссылку на метод команды.
        /// </summary>
        public readonly Action<object> _executeAction;

        /// <summary>
        /// Создаёт экземпляр команды <see cref="RelayCommand"/>
        /// </summary>
        /// <param name="excutionAction">Метод команды.</param>
        public RelayCommand(Action<object> excutionAction)
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
        /// Хранит логику команды.
        /// </summary>
        /// <param name="parameter"></param>
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
