using Color_Generator.Models;
using Color_Generator.ViewModels;

namespace Color_Generator.Commands
{
    public class ExpandColorCommand : CommandBase
    {
        private readonly MainViewModel _mainViewModel;

        public ExpandColorCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public override void Execute(object parameter)
        {
            if (parameter is not UserColor)
            {
                return;
            }

            _mainViewModel.CurrentColor = ((UserColor)parameter).Copy();
        }
    }
}
