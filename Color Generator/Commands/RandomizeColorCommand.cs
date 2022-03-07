using Color_Generator.Services;
using Color_Generator.ViewModels;

namespace Color_Generator.Commands
{
    public class RandomizeColorCommand : CommandBase
    {
        private readonly MainViewModel _mainViewModel;

        public RandomizeColorCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public override void Execute(object parameter)
        {
            UserColorRandomizerService.Randomize(_mainViewModel.SettingsStore, _mainViewModel.CurrentColor);
        }
    }
}
