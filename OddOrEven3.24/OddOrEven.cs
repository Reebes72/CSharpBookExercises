using System;

namespace OddOrEven3._24
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int evenOrOdd;
            bool again = true;
            string entry;
            while (again == true)
            {
                Console.WriteLine("Enter an Integer.");
                evenOrOdd = int.Parse(Console.ReadLine());

                if (evenOrOdd % 2 == 0)
                {
                    Console.WriteLine($"{evenOrOdd} is even.");
                }
                else
                {
                    Console.WriteLine($"{evenOrOdd} is odd.");
                }

                Console.WriteLine("Would you like to test another number?");
                entry = Console.ReadLine();

                if(entry.ToLower().Equals("y") != true)
                {
                    again = false;
                }

            }
            

        }
    }
}
