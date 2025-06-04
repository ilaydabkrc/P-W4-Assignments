using System;

namespace BabyExample
{
    public class Baby
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty ;

        public Baby()
        {
            BirthDate = DateTime.Now;
            Console.WriteLine("Ingaaaaa");
        }
        public Baby(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"İsim: {FirstName}, Soyad: {LastName}, Doğum Tarihi: {BirthDate}");
        }
    }
    class Program
    {
     static void Main(string[] args)
        {
            Baby baby1 = new Baby();
            baby1.FirstName = "Nilüfer";
            baby1.LastName = "TAŞÇI";
            baby1.PrintInfo();
            Console.ReadLine();
        }


    }
    

    }


