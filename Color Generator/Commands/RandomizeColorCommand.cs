using Color_Generator.Models;
using Color_Generator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Generator.Commands
{
    public class RandomizeColorCommand : CommandBase
    {
        private readonly UserColor _userColor;

        public RandomizeColorCommand(UserColor userColor)
        {
            _userColor = userColor;
        }

        public override void Execute(object parameter)
        {
            UserColorRandomizerService.Randomize(_userColor);
        }
    }
}
