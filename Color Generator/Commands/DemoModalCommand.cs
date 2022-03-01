using Color_Generator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Generator.Commands
{
    public class DemoModalCommand : CommandBase
    {
        private readonly INavigationService _navigationService;

        public DemoModalCommand(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
