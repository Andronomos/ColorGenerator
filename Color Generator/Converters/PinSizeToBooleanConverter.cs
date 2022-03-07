using System;
using System.Globalization;
using System.Windows.Data;

namespace Color_Generator.Converters
{
    public class PinSizeToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.Equals(parameter);
            //return (value as Enum).HasFlag((Enum)parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.Equals(true) == true ? parameter : Binding.DoNothing;
        }
    }
}
