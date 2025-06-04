using System;
namespace InheritanceExample
{
    class BasePerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"İsim: {FirstName}, Soyad: {LastName}");

        }
    }
    class Student : BasePerson
    {
        public int StudentNumber { get; set; }

        public void PrintStudentNumber()
        {
            PrintName();
            Console.WriteLine($"Öğrenci numarası: {StudentNumber}");
        }
    }
    class Teacher : BasePerson
    {
        public double Salary { get; set; }

        public void PrintTeacherInfo()
        {
            PrintName();
            Console.WriteLine($"Ücret: {Salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FirstName = "Efe";
            student.LastName = "Ergenç";
            student.StudentNumber = 1907;

            Console.WriteLine("Öğrenci bilgisi: ");
            student.PrintStudentNumber();
            Console.WriteLine();

            Teacher teacher = new Teacher();
            teacher.FirstName = "Ceku";
            teacher.LastName = "Taşçı";
            teacher.Salary = 1905;

            Console.WriteLine("Öğretmen bilgisi: ");
            teacher.PrintTeacherInfo();

            Console.ReadLine();


             

        }


    }



}
