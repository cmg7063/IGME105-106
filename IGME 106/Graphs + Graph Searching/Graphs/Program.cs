using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjacencyList adjList = new AdjacencyList();
            string start = "MASTER BEDROOM";

            Console.WriteLine("You are currently in the " + start);
            Console.WriteLine("Nearby are: ");

            foreach(string item in adjList.GetAdjacentList("MASTER BEDROOM"))
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Where would you like to go? ");

            while(1==1)
            {
                string input = Console.ReadLine().ToUpper();
                if (input == "EXIT")
                {
                    Console.WriteLine("You have successfully escaped this example.");
                    return;
                }
                else if(adjList.IsConnected(start, input.ToUpper()))
                {
                    start = input.ToUpper();

                    Console.WriteLine("You are currently in the " + start);
                    Console.WriteLine("Nearby are: ");
                    foreach (string item in adjList.GetAdjacentList(start))
                    {
                        Console.WriteLine(item + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Where would you like to go? ");
                }
                else
                {
                    Console.WriteLine("Whereever that is, it is not an adjacent room.");
                    break;
                }
            }
        }
    }
}
