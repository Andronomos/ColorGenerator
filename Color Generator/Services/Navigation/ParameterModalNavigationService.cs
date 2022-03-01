using Color_Generator.Stores;
using Color_Generator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Generator.Services
{
    public class ParameterModalNavigationService<TParameter, TViewModel> : IParamterNavigationService<TParameter> where TViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly Func<TParameter, TViewModel> _createViewModel;

        public ParameterModalNavigationService(ModalNavigationStore modalNavigationStore, Func<TParameter, TViewModel> createViewModel)
        {
            _modalNavigationStore = modalNavigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate(TParameter parameter)
        {
            _modalNavigationStore.CurrentViewModel = _createViewModel(parameter);
        }
    }
}
