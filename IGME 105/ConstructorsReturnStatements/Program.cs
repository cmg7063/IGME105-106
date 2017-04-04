using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsReturnStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();

            Console.Write("Enter a width: ");
            map.width = int.Parse(Console.ReadLine());
            Console.Write("Enter a height: ");
            map.height = int.Parse(Console.ReadLine());
            Console.Write("Enter the size of the monsters : ");
            map.size = double.Parse(Console.ReadLine());

            Console.WriteLine("The area of the map is: " + map.CalculateTotalArea());
            Console.WriteLine("The area of the grass is: " + map.CalculateGrassArea());
            Console.WriteLine("The map can hold " + map.CalculateMaxMonsters() + " monsters.");
        }
    }
}
