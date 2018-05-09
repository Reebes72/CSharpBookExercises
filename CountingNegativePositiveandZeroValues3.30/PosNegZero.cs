using System;

namespace CountingNegativePositiveandZeroValues3._30
{
    class PosNegZero
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[5];
            Console.WriteLine("This program takes the input of 5 integers and returns the number of positive, negative, and zeros.");

            for (int i = 1; i <= inputArray.Length;)
            {
                Console.WriteLine($"Input number {i}: ");
                try
                {
                    inputArray[i - 1] = int.Parse(Console.ReadLine());
                    i++;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Enter an integer.");
                }
            }

            int pos =0 , neg = 0, zero = 0;
            foreach(int e in inputArray)
            {
                if(e > 0)
                {
                    pos++;
                }
                if(e < 0)
                {
                    neg++;
                }
                if(e == 0)
                {
                    zero++;
                }
            }

            Console.WriteLine($"The number of positive numbers is: {pos}");
            Console.WriteLine($"The number of negative numbers is: {neg}");
            Console.WriteLine($"The number of zeros is:            {zero}");       

        }
    }
}
