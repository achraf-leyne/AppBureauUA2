using System;
using System.Windows.Input;

namespace WpfMvvmUA2.Commands
{
    public class MyICommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private readonly Action<object> _execute;
        private readonly Predicate<object>? _canExecute;

        public MyICommand(Action<object> executeMethod, Predicate<object>? canExecuteMethod = null)
        {
            _execute = executeMethod ?? throw new ArgumentNullException(nameof(executeMethod));
            _canExecute = canExecuteMethod;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
