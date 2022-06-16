using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {    //5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} centuries = {number*100} years = {(int)(number*100* 365.2422) } days = {(int)(number*100* 365.2422 * 24)} hours = {(int)(number * 100 * 365.2422 * 24 * 60)} minutes");
        }
    }
}
