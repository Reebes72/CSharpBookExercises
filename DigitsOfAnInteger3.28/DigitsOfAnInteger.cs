using System;

namespace DigitsOfAnInteger3._28
{
    class DigitsOfAnInteger
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Input a 5-digit number.");
            int userEntry = int.Parse(Console.ReadLine());

            for(int i = 0; i <5; i++)
            {
                array[i] = userEntry % 10;
                userEntry /= 10;
                
            }

            Console.WriteLine();
            for(int i = array.Length -1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();

            //If you enter a number smaller than 4 digits it will put a zero in the result
            //If you enter a number greater than 4 digits it will omit the digits representing the largest factor (ex. 123456 will display 2 3 4 5 6 
        }
    }
}
