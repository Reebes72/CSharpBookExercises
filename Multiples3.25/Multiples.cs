using System;

namespace Multiples3._25
{
    class Multiples
    {
        static void Main(string[] args)
        {
            int first, second;
            bool again = true;
            string entry;


            while (again == true)
            {
                Console.WriteLine("Please enter two integers.");

                Console.WriteLine("First integer:");
                first = int.Parse(Console.ReadLine());

                Console.WriteLine("Second integer:");
                second = int.Parse(Console.ReadLine());

                if (first % second == 0)
                {
                    Console.WriteLine($"{first} is a multiple of {second}");
                }
                else
                {
                    Console.WriteLine($"{first} is not a multiple of {second}");
                }

                Console.WriteLine("Would you like to test two additional numbers?");
                entry = Console.ReadLine();

                if (entry.ToLower().Equals("y") != true)
                {
                    again = false;
                }
            }
        }
    }
}
