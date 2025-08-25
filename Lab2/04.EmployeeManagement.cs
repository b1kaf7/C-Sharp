using System;

namespace EmployeeManagement
{

    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
        }
    }


    class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string name, double salary, string dept) : base(name, salary)
        {
            Department = dept;
        }


        public override void DisplayDetails()
        {
            Console.WriteLine($"Manager: {Name}, Salary: {Salary}, Department: {Department}");
        }


        public new void DisplayDetails(bool showDept)
        {
            if (showDept)
                Console.WriteLine($"Manager: {Name}, Department: {Department}");
            else
                Console.WriteLine($"Manager: {Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management");

            Employee emp = new Employee("Rohan", 50000);
            emp.DisplayDetails();

            Manager mgr = new Manager("Ajit", 80000, "IT");
            mgr.DisplayDetails();        // overridden method
            mgr.DisplayDetails(true);    // hidden method

            Employee empRef = mgr;
            empRef.DisplayDetails();     // calls overridden method
        }
    }
}