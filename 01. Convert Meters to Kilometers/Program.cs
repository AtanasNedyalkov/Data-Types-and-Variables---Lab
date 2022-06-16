using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kiloMeters = meters*0.001;
            Console.WriteLine($"{kiloMeters:f2}");
        }
    }
}
