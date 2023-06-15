using Calculator_Labb7.Controller;
using Calculator_Labb7.Services;

namespace Calculator_Labb7.Application
{
    public class App
    {
        private Calculator calculator;
        private UIControlls controlls;
        public App()
        {
            calculator = new Calculator();
            controlls = new UIControlls();
        }

        public void Run()
        {
            Program();
        }

        private void Program()
        {
            bool IsRunning = true;
            while (IsRunning)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1. Perform Math Operation");
                Console.WriteLine("2. Check Calculation History");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        MathOperation();
                        break;
                    case "2":
                        EquationHistory();
                        break;
                    case "3":
                        IsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        private void EquationHistory()
        {
            Console.WriteLine("Previous Calculations:");
            foreach (var item in calculator.GetHistory())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private void MathOperation()
        {
            Console.WriteLine("First Number");
            bool IsValidNum1 = controlls.UserInput(Console.ReadLine(), out decimal num1);
            Console.WriteLine("Second Number");
            bool IsValidNum2 = controlls.UserInput(Console.ReadLine(), out decimal num2);

            if (!IsValidNum1 || !IsValidNum2)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            Console.WriteLine("Enter Operation + - / *");
            string operation = Console.ReadLine();
            decimal result = 0;
            switch (operation)
            {
                case "+":
                    result = calculator.Add(num1, num2);
                    break;
                case "-":
                    result = calculator.Subtract(num1, num2);
                    break;
                case "*":
                    result = calculator.Multiply(num1, num2);
                    break;
                case "/":
                    result = calculator.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}
