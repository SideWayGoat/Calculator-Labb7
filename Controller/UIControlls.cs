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
