using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Color_Generator.Services
{
    public static class HexConverterService
    {
        public static Color ConvertToColor(string hex)
        {
            try
            {
                return (Color)ColorConverter.ConvertFromString($"#{hex}");
            }
            catch (Exception)
            {
                return Colors.Blue;
            }
        }
    }
}
