using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// Corinne Green
// 27 February 2016
// FileData - A class that analyzes the data from a text file, counting the number of occurrences of each character in the file 

namespace Exam1BaseCode
{
    class FileData
    {
        // Attributes
        string fileName;
        Dictionary<char, int> charDictionary;    // Dictionary collection to store frequencies of characters

        public FileData(string fileName)
        {
            this.fileName = fileName;
            // Initialize charDictionary
            charDictionary = new Dictionary<char, int>();
            StreamReader reader = new StreamReader(File.OpenRead(fileName));    // Exceptions for this file will be handled in Main
        }

        // Analyze() method that populates the Dictionary collection of chars
        public void Analyze()
        {
            StreamReader reader = new StreamReader(File.OpenRead(fileName));

            try
            {
                // Iterate through each line until there are no more lines to go through in the file
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    // A foreach loop to iterate over each unique character on each line
                    foreach (char character in line)
                    {
                        if (charDictionary.ContainsKey(character))
                        {
                            charDictionary[character]++;
                        }
                        else
                        {
                            charDictionary[character] = 1;
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Display()
        {
            // Foreach var (inferred by compiler) in the Dictionary collection, print out its 'var' and number of occurances
            foreach (var pair in charDictionary)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
            }
        }
    }
}
