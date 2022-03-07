using Color_Generator.Models;
using Color_Generator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Color_Generator.Commands
{
    public class SetRGBFromHexCommand : CommandBase
    {
        private readonly UserColor _userColor;

        public SetRGBFromHexCommand(UserColor userColor)
        {
            _userColor = userColor;
        }

        public override void Execute(object parameter)
        {
            Color c = HexConverterService.ConvertToColor($"{parameter}");

            _userColor.R = c.R;
            _userColor.G = c.G;
            _userColor.B = c.B;
        }
    }
}
