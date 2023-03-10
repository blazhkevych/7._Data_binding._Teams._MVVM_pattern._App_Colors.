using System;
using System.Windows.Input;

namespace task.Commands;

// Класс команды, который использует делегаты. (шаблон для всех команд)
public class DelegateCommand : ICommand
{
    private readonly Predicate<object> _canExecute;

    private readonly Action<object> _execute;

    public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
    {
        if (execute == null)
            throw new ArgumentNullException("execute");
        _execute = execute;
        _canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
        if (_canExecute != null) return _canExecute(parameter);
        return true;
    }

    public void Execute(object parameter)
    {
        _execute(parameter);
    }

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}