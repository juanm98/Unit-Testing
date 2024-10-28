using System;

namespace MyFirstProgram
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            
            do
            {
                try
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine("Calculator Program");
                    Console.WriteLine("------------------");

                    double num1 = GetNumberInput("Enter number 1: ");
                    double num2 = GetNumberInput("Enter number 2: ");

                    DisplayMenu();
                    string option = Console.ReadLine();

                    double result = ExecuteOperation(calculator, option, num1, num2);
                    DisplayResult(num1, num2, option, result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("\nError: Cannot divide by zero!");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nAn error occurred. Please try again.");
                }

            } while (ContinueProgram());

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }

        private static double GetNumberInput(string prompt)
        {
            double number;
            do
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.");
            } while (true);
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Subtract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");
            Console.Write("Enter an option: ");
        }

        private static double ExecuteOperation(Calculator calculator, string option, double num1, double num2)
        {
            return option switch
            {
                "+" => calculator.Add(num1, num2),
                "-" => calculator.Subtract(num1, num2),
                "*" => calculator.Multiply(num1, num2),
                "/" => calculator.Divide(num1, num2),
                _ => throw new ArgumentException("Invalid operation")
            };
        }

        private static void DisplayResult(double num1, double num2, string operation, double result)
        {
            Console.WriteLine($"Your result: {num1} {operation} {num2} = {result}");
        }

        private static bool ContinueProgram()
        {
            do
            {
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
                string response = Console.ReadLine()?.ToUpper() ?? "N";
                
                if (response == "Y" || response == "N")
                    return response == "Y";
                    
                Console.WriteLine("Invalid input. Please enter Y or N.");
            } while (true);
        }
    }
}