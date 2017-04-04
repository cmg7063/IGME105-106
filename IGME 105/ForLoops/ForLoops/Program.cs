using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int numberTwo = 101;
            //This is a while loop
            while (number < 10)
            {
                number++;
                Console.WriteLine(number);
            }

            Console.WriteLine();
            //This is a do/while loop
            do
            {
                numberTwo--;
                Console.WriteLine(numberTwo);
            }
            while (numberTwo > 90);

            Console.WriteLine();
            //This is a for loop
            for(int i = 0; i < 51; i+=5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.Write("Enter a width: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a height: ");
            int height = int.Parse(Console.ReadLine());

            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {
                        Console.Write("*");
                    }
                    else if (j == 0 || j == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
