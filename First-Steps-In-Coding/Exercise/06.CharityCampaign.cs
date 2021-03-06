using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());

            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = 45;
            double wafflePrice = 5.80;
            double pancakePrice = 3.20;

            double profit = days * bakers * ((cakes * cakePrice) + (waffles * wafflePrice) + (pancakes * pancakePrice));
            double profitAfterExpenses = profit - (profit / 8);

            Console.WriteLine(profitAfterExpenses);
        }
    }
}
