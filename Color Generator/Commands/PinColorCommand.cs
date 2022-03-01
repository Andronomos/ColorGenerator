using Color_Generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Generator.Commands
{
    public class PinColorCommand : CommandBase
    {
        private readonly UserColor _userColor;
        private readonly List<UserColor> _pinnedColors;

        public PinColorCommand(UserColor userColor, List<UserColor> pinnedColors)
        {
            _userColor = userColor;
            _pinnedColors = pinnedColors;
        }

        public override void Execute(object parameter)
        {
            _pinnedColors.Add(_userColor);
        }
    }
}
