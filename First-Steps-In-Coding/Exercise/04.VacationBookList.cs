using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double hoursePerDay = pagesInBook / pagesPerHour / days;
            Console.WriteLine(hoursePerDay);
        }
    }
}
