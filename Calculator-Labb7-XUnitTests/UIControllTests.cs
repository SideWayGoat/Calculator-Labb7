using Calculator_Labb7.Controller;
using Calculator_Labb7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Labb7_XUnitTests
{
    public class UIControllTests
    {
        [Fact]
        public void UserInput_ShouldWorkOnPositiveNumbers()
        {
            var userInput = new UIControlls();
            var cal = new Calculator();

            //Input from user
            string a = "2";
            string b = "3";

            var input1 = userInput.UserInput(a);
            var input2 = userInput.UserInput(b);

            var result = cal.Add(input1, input2);
            decimal expected = 5;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void UserInput_ShouldWorkOnNegativeNumbers()
        {
            var userInput = new UIControlls();
            var cal = new Calculator();

            string a = "-2";
            string b = "-3";

            var input1 = userInput.UserInput(a);
            var input2 = userInput.UserInput(b);

            var result = cal.Add(input1, input2);

            decimal expected = -5;

            Assert.Equal(expected, result);
        }
    }
}
