using System;

namespace ProjectsDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());
            int time = projectsCount * 3;

            Console.WriteLine($"The architect {architectName} will need {time} hours to complete {projectsCount} project/s.");
        }
    }
}
