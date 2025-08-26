using System;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
            }
        }
    }
}