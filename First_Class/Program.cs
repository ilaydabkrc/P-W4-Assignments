
using System;
using System.Collections.Generic;

namespace SchoolManagement
{
    // General class named Person
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Birth Date: {BirthDate.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Student objects
            Person student1 = new Person
            {
                FirstName = "Ahmet",
                LastName = "Yilmaz",
                BirthDate = new DateTime(2005, 4, 10)
            };

            Person student2 = new Person
            {
                FirstName = "Zeynep",
                LastName = "Kara",
                BirthDate = new DateTime(2006, 7, 15)
            };

            // Teacher objects
            Person teacher1 = new Person
            {
                FirstName = "Mehmet",
                LastName = "Demir",
                BirthDate = new DateTime(1985, 2, 20)
            };

            Person teacher2 = new Person
            {
                FirstName = "Elif",
                LastName = "Aksoy",
                BirthDate = new DateTime(1990, 9, 30)
            };

            // Adding all persons to a list and printing info
            List<Person> people = new List<Person> { student1, student2, teacher1, teacher2 };

            Console.WriteLine("People Information:");
            foreach (var person in people)
            {
                person.PrintInfo();
            }

            Console.ReadLine(); // Keeps the console window open
        }
    }
}








