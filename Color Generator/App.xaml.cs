using Color_Generator.Services;
using Color_Generator.Stores;
using Color_Generator.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Color_Generator
{
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly ColorStore _colorStore;

        public App()
        {
            _navigationStore = new NavigationStore();
            _modalNavigationStore = new ModalNavigationStore();
            _colorStore = new ColorStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new WindowViewModel(_navigationStore, _modalNavigationStore)
            };

            INavigationService demoNavigationService = CreateMainNavigationService();
            demoNavigationService.Navigate();

            MainWindow.Show();

            base.OnStartup(e);
        }

        private INavigationService CreateMainNavigationService()
        {
            return new NavigationService<MainViewModel>(_navigationStore, () => new MainViewModel(_navigationStore, _colorStore));
        }

        private INavigationService CreateCloseModalNavigationService()
        {
            return new CloseModalNavigationService(_modalNavigationStore);
        }
    }
}
