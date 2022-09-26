using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyCar = new Car();
            MyCar.Year = 2022;
            MyCar.Make = "Lamborghini";
            MyCar.Model = "Gallardo";
            Console.WriteLine("test");
            Console.WriteLine($"This is Jeremy's car, it is a {MyCar.Year} {MyCar.Make} {MyCar.Model}");
        }
    }
}

