using Color_Generator.Services;
using Color_Generator.Stores;

namespace Color_Generator.Commands
{
    public class SavePinnedColorsCommand : CommandBase
    {
        private readonly ColorStore _colorStore;
        private readonly SaveColorsService _saveColorsService;
        private readonly SettingsStore _settingsStore;


        public SavePinnedColorsCommand(ColorStore colorStore, SettingsStore settingsStore)
        {
            _colorStore = colorStore;
            _settingsStore = settingsStore;
            SaveColorsService saveColorsService = new(_settingsStore);
            _saveColorsService = saveColorsService;
        }

        public override void Execute(object parameter)
        {
            _saveColorsService.Save(_colorStore.Colors);
        }
    }
}
