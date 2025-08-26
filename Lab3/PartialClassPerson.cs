using System;

namespace PartialClassExample
{
    public partial class Person
    {
        public string Name;
        public int Age;
    }

    public partial class Person
    {
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Alice", Age = 25 };
            p.Display();
        }
    }
}