using Color_Generator.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Color_Generator.Converters
{
    public class RGBToHexStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte r = System.Convert.ToByte(values[0]);
            byte g = System.Convert.ToByte(values[1]);
            byte b = System.Convert.ToByte(values[2]);
            return $"{r:X2}{g:X2}{b:X2}";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            try
            {
                //Color c = (Color)ColorConverter.ConvertFromString($"#{value}");
                Color c = HexConverterService.ConvertToColor($"{value}");
                return new object[] { c.R, c.G, c.B };
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
