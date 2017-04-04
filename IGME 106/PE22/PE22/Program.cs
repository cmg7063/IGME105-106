using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create tree obj
            Tree tree = new Tree();

            Random rng = new Random();


            // Populate tree with randomly generated numbers
            tree.Insert(rng.Next(100));
            tree.Insert(rng.Next(42));
            tree.Insert(rng.Next(12));
            tree.Insert(rng.Next(53));
            tree.Insert(rng.Next(7));
            tree.Insert(rng.Next(52));
            tree.Insert(rng.Next(32));
            tree.Insert(rng.Next(15));
            tree.Insert(rng.Next(79));
            tree.Insert(rng.Next(30));
            tree.Insert(rng.Next(5));
            tree.Insert(rng.Next(50));

            tree.Print();
        }
    }
}
