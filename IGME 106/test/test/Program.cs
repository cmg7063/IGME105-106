using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("file.txt");
            string line = null;

            while (input.ReadLine() != null)

            {

                line = input.ReadLine();

                Console.Write(line + " ");

            }

        }
    }
}
