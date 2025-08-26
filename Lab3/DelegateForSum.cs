using System;

namespace DelegateExample
{
    class Program
    {
        delegate int SumDelegate(int a, int b);

        static int Add(int x, int y) => x + y;

        static void Main(string[] args)
        {
            SumDelegate del = Add;
            Console.WriteLine("Sum: " + del(10, 20));
        }
    }
}