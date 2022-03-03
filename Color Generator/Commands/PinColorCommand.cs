using Color_Generator.Models;
using Color_Generator.Stores;
using Color_Generator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Generator.Commands
{
    public class PinColorCommand : CommandBase
    {
        private MainViewModel _viewModel;

        public PinColorCommand(MainViewModel mainViewModel)
        {
            _viewModel = mainViewModel;
        }

        public override void Execute(object parameter)
        {
            _viewModel.ColorStore.AddColor(_viewModel.CurrentColor.Copy());
        }
    }
}
