using System;
namespace CalisanOrnek
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

        public abstract void Task();
    }
    class SoftwareDeveloper : Employee
    {
        public override void Task()
        {
            Console.WriteLine("Yazılım geliştici olarak çalışıyorum.");
        }

    }
    class ProjectManager : Employee
    {
        public override void Task()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }

    }
    class SalesRepresentative : Employee
    {
        public override void Task()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Bir proje yöneticisi nesnesi oluşturalım
            ProjectManager hasan = new ProjectManager
            {
                FirstName = "Hasan",
                LastName = "Çıldırmış",
                Department = "Proje Yönetimi"
            };

            Console.WriteLine($"{hasan.FirstName} {hasan.LastName} şirketin {hasan.Department} departmanında çalışıyor.");
            hasan.Task();

            Console.WriteLine();

            // Diğer örnekler
            SoftwareDeveloper ayse = new SoftwareDeveloper
            {
                FirstName = "Ayşe",
                LastName = "Demir",
                Department = "Yazılım"
            };
            Console.WriteLine($"{ayse.FirstName} {ayse.LastName} şirketin {ayse.Department} departmanında çalışıyor.");
            ayse.Task();

            SalesRepresentative ali = new SalesRepresentative
            {
                FirstName = "Ali",
                LastName = "Kaya",
                Department = "Satış"
            };
            Console.WriteLine($"{ali.FirstName} {ali.LastName} şirketin {ali.Department} departmanında çalışıyor.");
            ali.Task();

            Console.ReadLine(); // Konsol kapanmasın
        }
    }



}
