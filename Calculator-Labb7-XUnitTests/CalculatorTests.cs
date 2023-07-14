using Calculator_Labb7.Services;

namespace Calculator_Labb7_XUnitTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(3, 3, 6)]
        [InlineData(5, 4, 9)]
        [InlineData(1, 3, 4)]
        [InlineData(10, 4, 14)]
        [InlineData(4.2, 6.54, 10.74)]
        [InlineData(3, -5, -2)]
        [InlineData(-4, -5, -9)]
        public void Calculator_Add_ShouldReturnValues(decimal a, decimal b, decimal expected)
        {
            var cal = new Calculator();

            var sum = cal.Add(a, b);

            Assert.Equal(expected, sum);
        }

        [Fact]
        public void Calculator_History_ShouldContainHistory()
        {
            var cal = new Calculator();
            decimal a = 1;
            decimal b = 2;


            cal.Add(a, b);
            List<string> history = cal.GetHistory();


            Assert.Single(history);
            Assert.Equal($"{a} + {b} = {a + b}", history[0]);
        }

        [Theory]
        [InlineData(6.4, 2.1, 3.05)]
        [InlineData(14.2, 4.2, 3.38)]
        [InlineData(19.6, 5.6, 3.5)]
        [InlineData(10, 2, 5)]
        [InlineData(-10.2, -2.2, 4.64)]
        public void Calculator_Divide_ShouldDivideTwoNumbers(decimal a, decimal b, decimal expected)
        {
            var cal = new Calculator();

            var sum = cal.Divide(a, b);

            Assert.Equal(expected, sum);
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(5.2, 4, 20.8)]
        [InlineData(-10, 2, -20)]
        [InlineData(20, -2, -40)]
        [InlineData(5.5, 2.2, 12.1)]
        public void Multiply_ShouldReturnA_times_B(decimal a, decimal b, decimal expected)
        {
            var cal = new Calculator();

            var sum = cal.Multiply(a, b);

            Assert.Equal(expected, sum);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(10, 4, 6)]
        [InlineData(2, 2, 0)]
        [InlineData(-2, -4, 2)]
        [InlineData(10.23, 4.22, 6.01)]
        [InlineData(5, 20, -15)]
        public void Subtract_ShouldReturnValueOfA_Subtracting_B(decimal a, decimal b, decimal expected)
        {
            var cal = new Calculator();

            var sum = cal.Subtract(a, b);

            Assert.Equal(expected, sum);
        }
        [Fact]
        public void Divide_ShouldThrowDivideByZeroExeption()
        {
            var cal = new Calculator();

            decimal a = 22;
            decimal b = 0;

            Assert.Throws<DivideByZeroException>(() => cal.Divide(a, b));
        }

    }
}