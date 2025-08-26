using System;

namespace SealedClassExample
{
    class Vehicle
    {
        public virtual void DisplayType()
        {
            Console.WriteLine("This is a vehicle");
        }
    }

    sealed class Car : Vehicle
    {
        public override void DisplayType()
        {
            Console.WriteLine("This is a car");
        }
    }

    // This would cause a compiler error
    // class SportsCar : Car {}

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.DisplayType();
        }
    }
}