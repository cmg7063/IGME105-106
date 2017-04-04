using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryRW bin = new BinaryRW();
            BinaryRW bin2 = new BinaryRW();
            BinaryRW bin3 = new BinaryRW();
            BinaryRW bin4 = new BinaryRW();

            bin.WriteBinary("Fokker DR 1", "Germany", 'D', 'A', 1000.0, 13, "plane1.dat");
            bin2.WriteBinary("SPAD XII", "France", 'A', 'A', 1250.50, 16, "plane2.dat");
            bin3.WriteBinary("Sopwith Camel", "England", 'C', 'A', 890.0, 15, "plane3.dat");
            bin4.WriteBinary("Albatros D", "Germany", 'B', 'A', 1575.75, 15, "plane4.dat");

            // Get directory of ALL files
            string[] files = Directory.GetFiles(".");
            foreach (string file in files)
            {
                // If said file contains "plane1"
                if (file.Contains("plane1"))
                {
                    bin.ReadBinary("plane1.dat");
                    Console.WriteLine();
                }
                if (file.Contains("plane2"))
                {
                    bin2.ReadBinary("plane2.dat");
                    Console.WriteLine();
                }
                if (file.Contains("plane3"))
                {
                    bin3.ReadBinary("plane3.dat");
                    Console.WriteLine();
                }
                if (file.Contains("plane4"))
                {
                    bin4.ReadBinary("plane4.dat");
                }
            }
        }
    }
}
