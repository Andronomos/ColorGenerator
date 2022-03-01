using Color_Generator.Commands;
using Color_Generator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Color_Generator.ViewModels
{
    public class DemoModalViewModel : ViewModelBase
    {
        public ICommand CloseModalCommand { get; set; }

        public DemoModalViewModel(INavigationService navigationService)
        {
            CloseModalCommand = new CloseModalCommand(navigationService);
        }
    }
}
