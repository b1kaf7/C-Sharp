using System;

namespace StudentManagementSystem
{
    
    class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Student()
        {
            StudentID = 0;
            FirstName = "";
            LastName = "";
            EnrollmentDate = DateTime.Now;
        }

        public Student(int id, string first, string last, DateTime date)
        {
            StudentID = id;
            FirstName = first;
            LastName = last;
            EnrollmentDate = date;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {StudentID}, Name: {FirstName} {LastName}, Enrollment: {EnrollmentDate.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Management System");

            Student student1 = new Student();
            student1.DisplayInfo();

            Student student2 = new Student(101, "Binamra", "Kafle", new DateTime(2025, 7, 23));
            student2.DisplayInfo();
        }
    }
}