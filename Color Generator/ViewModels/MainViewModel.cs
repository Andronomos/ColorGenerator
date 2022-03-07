using Color_Generator.Commands;
using Color_Generator.Models;
using Color_Generator.Services;
using Color_Generator.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Color_Generator.ViewModels
{


    public class MainViewModel : ViewModelBase
    {
        private UserColor _currentColor;

        public SettingsStore SettingsStore { get; }
        public ColorStore ColorStore { get; }
        public ObservableCollection<UserColor> PinnedColors { get; private set; }
        //public ObservableCollection<PinnedColorViewModel> PinnedColors { get; } = new();

        public UserColor CurrentColor
        {
            get => _currentColor;
            set
            {
                _currentColor = value;
                OnPropertyChanged();
            }
        }

        public ICommand SetHexCommand { get; set; }
        public ICommand RandomizeColorCommand { get; set; }
        public ICommand PinColorCommand { get; set; }
        public ICommand SavePinnedColorsCommand { get; set; }
        public ICommand CopyHexCommand { get; set; }
        public ICommand ExpandColorCommand { get; set; }
        public ICommand ToggleLockCommand { get; set; }

        public MainViewModel(SettingsStore settingsStore, ColorStore colorStore)
        {
            SettingsStore = settingsStore;
            ColorStore = colorStore;
            ColorStore.ColorsChanged += ColorStoreColorsChangedEventHandler;
            OnPropertyChanged(nameof(PinnedColors));
            CurrentColor = new();
            UserColorRandomizerService.Randomize(settingsStore, CurrentColor);
            SetHexCommand = new SetRGBFromHexCommand(CurrentColor);
            RandomizeColorCommand = new RandomizeColorCommand(this);
            PinColorCommand = new PinColorCommand(this);
            SavePinnedColorsCommand = new SavePinnedColorsCommand(colorStore, settingsStore);
            CopyHexCommand = new CopyHexCommand();
            ExpandColorCommand = new ExpandColorCommand(this);
            ToggleLockCommand = new ToggleLockCommand(settingsStore);
        }

        private void ColorStoreColorsChangedEventHandler(object sender, EventArgs e)
        {
            PinnedColors = new ObservableCollection<UserColor>(ColorStore.Colors);

            //PinnedColorViewModel pvm = new(ColorStore);
            //pvm.UserColor = CurrentColor.Copy();
            //PinnedColors.Add(pvm);

            OnPropertyChanged(nameof(PinnedColors));
        }
    }
}
