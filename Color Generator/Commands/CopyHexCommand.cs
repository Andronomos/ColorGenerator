using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Color_Generator.Commands
{
    public class CopyHexCommand : CommandBase
    {
        public override void Execute(object parameter)
        {
            Clipboard.SetText(parameter.ToString());
        }
    }
}
