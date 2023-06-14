using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator_Labb7.Controller
{
    public class UIControlls
    {
        private static readonly Regex regex = new Regex(@"^-?\d+(\.\d+)?$");

        public decimal UserInput(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            else if (regex.IsMatch(input))
            {
                if (decimal.TryParse(input, out decimal result))
                {
                    return result;
                }
            }

            throw new FormatException("Invalid input format");
        }
    }
}
