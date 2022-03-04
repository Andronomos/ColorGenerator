using Color_Generator.Services;
using Color_Generator.Stores;

namespace Color_Generator.Commands
{
    public class SavePinnedColorsCommand : CommandBase
    {
        private readonly ColorStore _colorStore;
        private readonly SaveColorsService _saveColorsService;
        private readonly string _savePath;

        public SavePinnedColorsCommand(ColorStore colorStore, int bitmapWidth, int bitmapHeight, string savePath)
        {
            _colorStore = colorStore;
            _savePath = savePath;
            SaveColorsService saveColorsService = new SaveColorsService(bitmapWidth, bitmapHeight, _savePath);
            _saveColorsService = saveColorsService;
        }

        public override void Execute(object parameter)
        {
            _saveColorsService.Save(_colorStore.Colors);
        }
    }
}
