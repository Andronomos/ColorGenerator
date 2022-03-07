using Color_Generator.Commands;

namespace System.Windows.Input
{
    public class RelayCommand<T> : CommandBase
    {
        private readonly Action<T> _execute = null;
        private readonly Predicate<T> _canExecute = null;

        /// <summary>
        /// Creates a new command that can always execute.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        public RelayCommand(Action<T> execute) : this(execute, null)
        {
        }

        /// <summary>
        /// Creates a new command with conditional execution.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        public override bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute((T)parameter);
        }

        public override void Execute(object parameter)
        {
            _execute((T)parameter);
        }
    }

    public class RelayCommand : CommandBase
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute = null;

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action execute) : this(execute, () => true)
        {
        }

        public override bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        public override void Execute(object parameter)
        {
            _execute();
        }
    }
}