using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Greet");
        Console.WriteLine("2. Farewell");
        Console.WriteLine("3. Exit");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Hello there! Hope you have a great day.");
                break;
            case 2:
                Console.WriteLine("Goodbye! Take care.");
                break;
            case 3:
                Console.WriteLine("Exiting program...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}