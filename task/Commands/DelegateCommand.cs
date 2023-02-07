using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace task.Commands
{
    // Класс команды, который использует делегаты. (шаблон для всех команд)
    public class DelegateCommand : ICommand
    {
        // Конструктор.
        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
                return _canExecute(parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        private Action<object> _execute;

        private Predicate<object> _canExecute;
    }
}
