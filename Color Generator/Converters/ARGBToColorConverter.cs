using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Color_Generator.Converters
{
    public class ARGBToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values[0] == DependencyProperty.UnsetValue)
            {
                return null;
            }

            byte a = System.Convert.ToByte(values[0]);
            byte r = System.Convert.ToByte(values[1]);
            byte g = System.Convert.ToByte(values[2]);
            byte b = System.Convert.ToByte(values[3]);
            return Color.FromArgb(a, r, g, b);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
