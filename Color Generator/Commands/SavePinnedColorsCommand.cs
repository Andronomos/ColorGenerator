using Color_Generator.Models;
using Color_Generator.Services;
using System.Collections.ObjectModel;

namespace Color_Generator.Commands
{
    public class SavePinnedColorsCommand : CommandBase
    {
        private readonly ObservableCollection<UserColor> _pinnedColors;
        private readonly SaveColorsService _saveColorsService;
        private readonly string _savePath;
        private readonly int _bmpWidth;
        private readonly int _bmpHeight;

        public SavePinnedColorsCommand(ObservableCollection<UserColor> pinnedColors, int bmpWidth, int bmpHeight, string savePath)
        {
            _pinnedColors = pinnedColors;
            _bmpWidth = bmpWidth;
            _bmpHeight = bmpHeight;
            _savePath = savePath;
            SaveColorsService saveColorsService = new SaveColorsService(_bmpWidth, _bmpHeight, _savePath);
            _saveColorsService = saveColorsService;
        }

        public override void Execute(object parameter)
        {
            _saveColorsService.Save(_pinnedColors);
        }
    }
}
