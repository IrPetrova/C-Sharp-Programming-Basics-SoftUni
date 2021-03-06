using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananasKg = double.Parse(Console.ReadLine());
            double orangesKg = double.Parse(Console.ReadLine());
            double raspberriesKg = double.Parse(Console.ReadLine());
            double strawberriesKg = double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberriesPrice / 2;
            double orangesPrice = raspberriesPrice - (0.4 * raspberriesPrice);
            double bananasPrice = raspberriesPrice - (0.8 * raspberriesPrice);

            double moneyNeeded = strawberriesKg * strawberriesPrice + bananasKg * bananasPrice + orangesKg * orangesPrice + raspberriesKg * raspberriesPrice;

            Console.WriteLine("{0:0.00}", moneyNeeded);
        }
    }
}
