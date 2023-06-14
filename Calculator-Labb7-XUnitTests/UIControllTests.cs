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
            decimal result1 = 0;
            decimal result2 = 0;
            var input1 = userInput.UserInput(a, out result1);
            var input2 = userInput.UserInput(b, out result2);
            
            var result = cal.Add(result1, result2);
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
            decimal result1 = 0;
            decimal result2 = 0;
            var input1 = userInput.UserInput(a, out result1);
            var input2 = userInput.UserInput(b, out result2);

            var result = cal.Add(result1, result2);

            decimal expected = -5;

            Assert.Equal(expected, result);
        }

        //[Fact]
        //public void UserInput_ShouldThrowFormatExceptionIfLetter()
        //{
        //    var userInput = new UIControlls();

        //    Assert.Throws<FormatException>(() => userInput.UserInput("k", out decimal result));
        //}
    }
}
