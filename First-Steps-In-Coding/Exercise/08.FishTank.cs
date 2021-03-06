using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int totalVolume = length * width * height;
            double freeVolume = totalVolume - ((percent / 100 * totalVolume));
            double liters = freeVolume / 1000;

            Console.WriteLine(liters.ToString("F5"));
        }
    }
}
