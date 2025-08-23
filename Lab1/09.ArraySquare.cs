using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numsArray = { 2, 4, 6, 8 };

        foreach (int num in numsArray)
        {
            Console.WriteLine($"{num} squared is {num * num}");
        }
    }
}