using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Dictionary<string, bool> dictionary = new Dictionary<string, bool>();

            try
            {
                StreamReader reader = new StreamReader(File.OpenRead("dictionary.txt"));

                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    words.Add(line);
                    dictionary.Add(line, false);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Could not find file!" + ex.Message);
            }
            /* List - Takes a long time
            foreach(String word in words)
            {
                string doubleword = word + word;
                if (words.Contains(doubleword))
                {
                    Console.WriteLine(doubleword);
                }
            }
            */

            // Dictionary - Takes about .5 seconds
            foreach(String word in dictionary.Keys.ToList())
            {
                string doubleword = word + word;
                if (dictionary.ContainsKey(doubleword))
                {
                    //Console.WriteLine(doubleword);
                    dictionary[doubleword] = true;
                }
            }
            Console.WriteLine("Enter a word: ");
            while (1 == 1)
            {
                String input = Console.ReadLine().ToLower();
                try
                {
                    dictionary.ContainsKey(input);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                string doubleInput = input + input;
                if(dictionary[doubleInput] == true)
                {
                    Console.WriteLine(doubleInput + " is a valid double word.");
                }
            }
        }
    }
}
