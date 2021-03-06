using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());

            double pricePerSqM = 7.61;
            double billBeforeDiscount = area * pricePerSqM;
            double discount = 0.18 * billBeforeDiscount;
            double billAfterDiscount = billBeforeDiscount - discount;

            Console.WriteLine("The final price is " + billAfterDiscount + " lv.");
            Console.WriteLine("The discount is " + discount + " lv.");
        }
    }
}
