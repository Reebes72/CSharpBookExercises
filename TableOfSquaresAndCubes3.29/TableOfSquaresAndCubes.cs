using System;

namespace TableOfSquaresAndCubes3._29
{
    class TableOfSquaresAndCubes
    {
        static void Main(string[] args)
        {
            //string number = "number";
            //string square = "square";
            //string cube = "cube";

            //string format ="{-10};
            string format = "{0, -10}";
            //Issue arose out of how this is structured. The first value must be present, even if there is only one value. Not doing so will cause an exception.

            int num, sqr, cub;
            //Console.WriteLine(string.Format(format, number) + string.Format(format, square) + string.Format(format, cube));
            //Can Easily refactor to not use string objects
            Console.WriteLine(string.Format(format, "number") + string.Format(format, "square") + string.Format(format, "cube"));

            for(int i = 0; i <= 10; i++)
            {
                num = i;
                sqr = i * i;
                cub = i * i * i;
                Console.WriteLine(string.Format(format, num) + string.Format(format, sqr) + string.Format(format, cub));
                //Initially thought the ToString() method would have to be called because errors were occuring. Turns out, once the format is properly established, that is unneccesary.
            }

            Console.ReadLine();
        }
    }
}
