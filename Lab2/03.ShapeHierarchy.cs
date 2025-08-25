using System;

namespace ShapeHierarchy
{
    class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public virtual double CalculateArea()
        {
            return 0.0;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Hierarchy");

            Circle circle = new Circle("Circle1", 5.0);
            Console.WriteLine($"{circle.Name} Area: {circle.CalculateArea():F2}");

            Rectangle rectangle = new Rectangle("Rectangle1", 4.0, 6.0);
            Console.WriteLine($"{rectangle.Name} Area: {rectangle.CalculateArea():F2}");
        }
    }
}