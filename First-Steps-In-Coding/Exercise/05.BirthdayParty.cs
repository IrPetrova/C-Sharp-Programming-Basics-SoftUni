using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = 0.2 * rent;
            double drinks = cake - (0.45 * cake);
            double animator = rent / 3;

            double totalExpenses = rent + cake + drinks + animator;

            Console.WriteLine(totalExpenses);
        }
    }
}
