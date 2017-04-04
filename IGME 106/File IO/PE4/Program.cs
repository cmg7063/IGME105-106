using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PE4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a text file called fighterData.txt
            StreamWriter writer = new StreamWriter("fighterData.txt");
            writer.WriteLine("Fokker DR 1,Germany,D,A,13");
            writer.WriteLine("SPAD XIII,France,A,A,16");
            writer.WriteLine("Sopwith Camel,England,C,A,15");
            writer.WriteLine("Albatros B,Germany,B,A,15");
            writer.Close();

            // Read the data
            StreamReader reader = new StreamReader("fighterData.txt");
            string line = "";
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                Console.Write("Name: " + data[0] + " ");
                Console.Write("Country: " + data[1] + " ");
                Console.Write("Turn Mode: " + data[2] + " ");
                Console.Write("Attack Mode: " + data[3] + " ");
                Console.Write("Max Damage: " + data[4] + " ");
                Console.WriteLine();
            }
            reader.Close();
        }
    }
}
