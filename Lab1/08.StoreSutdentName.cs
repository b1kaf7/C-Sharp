using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> students = new List<string> { "Rohan", "Binamra", "Ajit" };

        foreach (string student in students)
        {
            Console.WriteLine($"Student: {student}");
        }
    }
}