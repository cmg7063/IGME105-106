using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[] numbers = new int [50000];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 10000);
            }

            // insertion sort algorithm
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = 0; j < numbers.Length-1; j++)
                {
                    if(numbers[j] > numbers[j+1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }                                  
                }                
            }
             Console.WriteLine("Done"); 
            /*
            // print results
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            */
        }
    }
}
