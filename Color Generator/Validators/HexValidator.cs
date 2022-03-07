using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Color_Generator.Validators
{
    public class HexValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value.ToString().Length < 3)
            {
                return new ValidationResult(false, "Hex length must be at least 3");
            }

            return new ValidationResult(true, null);
        }
    }
}
