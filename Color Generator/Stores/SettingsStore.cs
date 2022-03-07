using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Generator.Stores
{
    public enum PinSize
    {
        Small,
        Medium,
        Large
    }

    public class SettingsStore : ObservableObject
    {
        private bool _alphaIsLocked;
        private bool _redIsLocked;
        private bool _greenIsLocked;
        private bool _blueIsLocked;
        private int _savedBitmapWidth = 128;
        private int _savedBitmapHeight = 128;
        private string _savedBitmapPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";
        private PinSize _pinSize = PinSize.Medium;

        public bool AlphaIsLocked
        {
            get => _alphaIsLocked;
            set
            {
                _alphaIsLocked = value;
                OnPropertyChanged();
            }
        }

        public bool RedIsLocked
        {
            get => _redIsLocked;
            set
            {
                _redIsLocked = value;
                OnPropertyChanged();
            }
        }

        public bool GreenIsLocked
        {
            get => _greenIsLocked;
            set
            {
                _greenIsLocked = value;
                OnPropertyChanged();
            }
        }

        public bool BlueIsLocked
        {
            get => _blueIsLocked;
            set
            {
                _blueIsLocked = value;
                OnPropertyChanged();
            }
        }

        public int SavedBitmapWidth
        {
            get => _savedBitmapWidth;
            set
            {
                _savedBitmapWidth = value;
                OnPropertyChanged();
            }
        }

        public int SavedBitmapHeight
        {
            get => _savedBitmapHeight;
            set
            {
                _savedBitmapHeight = value;
                OnPropertyChanged();
            }
        }

        public string SavedBitmapPath
        {
            get => _savedBitmapPath;
            set
            {
                _savedBitmapPath = value;
                OnPropertyChanged();
            }
        }

        public PinSize PinSize
        {
            get => _pinSize;
            set
            {
                _pinSize = value;
                OnPropertyChanged();
            }
        }
    }
}
