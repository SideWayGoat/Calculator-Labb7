using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Labb7.Services
{
    public class Calculator
    {
        private List<string> history;
        public Calculator()
        {
            history = new List<string>();
        }
        public List<string> GetHistory()
        {
            return history;
        }

        public decimal Add(decimal a, decimal b)
        {
            string cal = $"{a} + {b} = {a + b}";
            history.Add(cal);
            return Math.Round(a + b, 2);
        }

        public decimal Divide(decimal a, decimal b)
        {
            try
            {
                string cal = $"{a} / {b} = {a / b}";
                history.Add(cal);
                return Math.Round(a / b, 2);
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("You can't divide by 0 you crazy person");
            }

        }

        public decimal Multiply(decimal a, decimal b)
        {
            string cal = $"{a} * {b} = {a * b}";
            history.Add(cal);
            return Math.Round(a * b, 2);
        }

        public decimal Subtract(decimal a, decimal b)
        {
            string cal = $"{a} - {b} = {a - b}";
            history.Add(cal);
            return Math.Round(a - b, 2);
        }

    }
}
