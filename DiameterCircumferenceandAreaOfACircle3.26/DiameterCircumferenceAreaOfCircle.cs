using System;

namespace DiameterCircumferenceandAreaOfACircle3._26
{
    class DiameterCircumferenceAreaOfCircle
    {
        static void Main(string[] args)
        {
            int userInput;
            bool again = true;
            string entry;

            while(again == true)
            {
                Console.WriteLine("Please enter an integer representing the radius of a circle.");
                userInput = int.Parse(Console.ReadLine());

                Console.WriteLine($"The diameter is: {userInput * 2}");
                Console.WriteLine($"The circumference is: {2 * Math.PI * userInput :F4}");
                Console.WriteLine($"The area is: {Math.PI * (userInput * userInput) :F4}\n");

                Console.WriteLine("Would you like to test another integer?");
                entry = Console.ReadLine();

                if (entry.ToLower().Equals("y") != true)
                {
                    again = false;
                }
            }
        }
    }
}
