using System;

namespace ArabaApp
{
    public class Car
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        private int doorCount;

        public int DoorCount
        {
            get { return doorCount; }
            set
            {
                if (value == 2 || value == 4)
                {
                    doorCount = value;
                }
                else
                {
                    Console.WriteLine("Kapı sayısı 2 veya 4 olmalı.");
                    doorCount = -1;

                }  
            }
        }

        public Car(string brand,string model,string color,int doorCount)
        {
            Brand = brand; 
            Model = model; 
            Color = color;
            DoorCount = doorCount;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Color: {Color}, Door Count: {DoorCount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Carolla", "White", 4);
            car1.PrintInfo();

            Car car2 = new Car("Ford", "Fiesta", "Red", 3);

            Console.ReadLine();
        }


    }

}
