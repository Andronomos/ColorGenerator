using Color_Generator.Commands;
using Color_Generator.Models;
using Color_Generator.Services;
using Color_Generator.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Color_Generator.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private string _savePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";
        private int _bitmapWidth = 128;
        private int _bitmapHeight = 128;


        public ObservableCollection<UserColor> PinnedColors { get; } = new();
        public UserColor CurrentColor { get; set; }

        public ICommand SetHexCommand { get; set; }
        public ICommand RandomizeColorCommand { get; set; }
        public ICommand PinColorCommand { get; set; }
        public ICommand SavePinnedColorsCommand { get; set; }
        public ICommand DemoModalCommand { get; set; }

        public MainViewModel(NavigationStore navigationStore, INavigationService demoModalNavigationService)
        {
            _navigationStore = navigationStore;
            OnPropertyChanged(nameof(PinnedColors));
            CurrentColor = new UserColor();
            UserColorRandomizerService.Randomize(CurrentColor);
            SetHexCommand = new SetRGBFromHexCommand(CurrentColor);
            RandomizeColorCommand = new RandomizeColorCommand(CurrentColor);
            //PinColorCommand = new PinColorCommand(CurrentColor, _pinnedColored);
            PinColorCommand = new RelayCommand(PinColor);
            SavePinnedColorsCommand = new SavePinnedColorsCommand(PinnedColors, _bitmapWidth, _bitmapHeight, _savePath);

            DemoModalCommand = new DemoModalCommand(demoModalNavigationService);
        }

        private void PinColor()
        {
            //UserColor uc = CurrentColor.Copy();

            //PinnedColors.Add(uc);
            PinnedColors.Add(CurrentColor.Copy());
        }
    }
}
