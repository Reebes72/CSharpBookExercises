using System;

namespace BodyMassIndexCalculator3._31
{
    class BMICalculator
    {
        static void Main(string[] args)
        {
            bool areYouDumb = true;
            int input = 0;
            double height, weight;
            Console.WriteLine("This program calculates you Body Mass Index.");
            DisplayBMIValues();
            while (areYouDumb == true)
            {
                try
                {
                    Console.WriteLine("Would you like to calculate in US or metric (1 for US, 2 for Metric)");
                    input = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                }
                switch(input)
                {
                    case 1:
                        Console.WriteLine("Enter your height in inches: ");
                        height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your weight in pounds: ");
                        weight = double.Parse(Console.ReadLine());
                        CalculateBMI(height * height, weight * 703);
                        areYouDumb = false;
                        break;
                    case 2:
                        Console.WriteLine("Enter your height in meters: ");
                        height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your weight in kilograms: ");
                        weight = double.Parse(Console.ReadLine());
                        CalculateBMI(height * height, weight);
                        areYouDumb = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        break;
                                        }
                   
             }



        }
        internal static void CalculateBMI(double height, double weight)
        {
            double bmi = weight / height;
            Console.WriteLine($"Your BMI is: {bmi:f2}");
        }

        internal static void DisplayBMIValues()
        {
            Console.WriteLine("Guidelines set down for proper BMI.\n");
            Console.WriteLine("BMI Values");
            Console.WriteLine("Underweight: less than 18.5");
            Console.WriteLine("Normal:      between 18.5 and 24.9");
            Console.WriteLine("Overweight:  between 25 and 29.9");
            Console.WriteLine("Obese:       30 or greater\n");
        }
    }
}
