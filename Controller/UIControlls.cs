using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator_Labb7.Controller
{
    public class UIControlls
    {
        /// <summary Regex Explaination>
        /// -? allows an optional minus sign (-) at the beginning of the number.
        /// \d* matches zero or more digits for the integral part of the number.
        /// \,? allows an optional comma (,) to match numbers without an integral part.
        /// \d+ matches one or more digits for the decimal part of the number.
        /// </summary>
        private static readonly Regex regex = new Regex(@"^-?\d*\,?\d+$");

        public bool UserInput(string input, out decimal result)
        {
            if (regex.IsMatch(input))
            {
                if (decimal.TryParse(input, out result))
                {
                    return true;
                }
            }
            result = 0;
            return false;
        }
    }
}
