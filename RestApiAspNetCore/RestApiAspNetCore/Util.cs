using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiAspNetCore
{
    public class Util
    {
        public static decimal ConvertToDecimal(string stringNumber)
        {
            decimal decimalValue;

            if (decimal.TryParse(stringNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        public static bool IsNumeric(string stringNumber)
        {
            double number;
            bool isNumber = double.TryParse(stringNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);

            return isNumber;
        }
    }
}
