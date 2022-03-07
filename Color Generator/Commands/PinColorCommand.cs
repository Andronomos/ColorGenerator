using Color_Generator.ViewModels;

namespace Color_Generator.Commands
{
    public class PinColorCommand : CommandBase
    {
        private MainViewModel _viewModel;

        public PinColorCommand(MainViewModel mainViewModel)
        {
            _viewModel = mainViewModel;
        }

        public override void Execute(object parameter)
        {
            _viewModel.ColorStore.AddColor(_viewModel.CurrentColor.Copy());
        }
    }
}
