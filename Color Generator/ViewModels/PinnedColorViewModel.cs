using Color_Generator.Models;
using Color_Generator.Stores;

namespace Color_Generator.ViewModels
{
    public class PinnedColorViewModel : ViewModelBase
    {
        private bool _showControls;
        private readonly ColorStore _colorStore;

        public bool ShowControls
        {
            get => _showControls;
            set
            {
                _showControls = value;
                OnPropertyChanged();
            }
        }

        public UserColor UserColor { get; set; }

        public PinnedColorViewModel(ColorStore colorStore)
        {
            _colorStore = colorStore;
        }
    }
}
