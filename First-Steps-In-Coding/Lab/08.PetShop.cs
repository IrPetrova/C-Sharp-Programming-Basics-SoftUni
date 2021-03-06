using System;

namespace PetSHop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());
            double dogFoodPrice = 2.50;
            double otherAnimalsFoodPrice = 4;

            double bill = dogs * dogFoodPrice + otherAnimals * otherAnimalsFoodPrice;
            Console.WriteLine(bill + " lv.");

        }
    }
}
