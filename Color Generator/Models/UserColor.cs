using Color_Generator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Color_Generator.Models
{
    public class UserColor : ObservableObject
    {
        private int _r;
        private int _g;
        private int _b;
        private string _hex;

        public int R
        {
            get => _r;
            set
            {
                _r = value;
                OnPropertyChanged();
            }
        }

        public int G
        {
            get => _g;
            set
            {
                _g = value;
                OnPropertyChanged();
            }
        }

        public int B
        {
            get => _b;
            set
            {
                _b = value;
                OnPropertyChanged();
            }
        }

        public string Hex
        {
            get => _hex;
            set
            {
                _hex = value;
                OnPropertyChanged();
                SetRGBFromHex(_hex);
            }
        }

        private void SetRGBFromHex(string hex)
        {
            Color c = HexConverterService.ConvertToColor($"{hex}");

            R = c.R;
            G = c.G;
            B = c.B;
        }

        public UserColor Copy()
        {
            return new UserColor()
            {
                R = _r,
                G = _g,
                B = _b
            };
        }
    }
}
