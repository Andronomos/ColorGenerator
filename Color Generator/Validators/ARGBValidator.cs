using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Color_Generator.Validators
{
    public class ARGBValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int colorValue;

            if (!int.TryParse(value.ToString(), out colorValue))
                return new ValidationResult(false, "Please enter a valid integer value.");

            if (colorValue < 0 || colorValue > 255)
                return new ValidationResult(false, "Please enter a valid integer value.");

            return new ValidationResult(true, null);
        }
    }
}
