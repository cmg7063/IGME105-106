using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Corinne Green
// ZombieData - A class that reads the phrases.txt and zombie.txt files and saves them to a list

namespace HW1
{
    class ZombieData
    {
        // Attributes
        private List<string> zombies;
        private List<string> phrases;

        public ZombieData()
        {
            // Initialize the two lists so that they are empty
            zombies = new List<string>();
            phrases = new List<string>();
        }

        public void LoadPhrases(string fileName)
        {
            try
            {
                // Read the data in the file
                StreamReader reader = new StreamReader(File.OpenRead(fileName));
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    phrases.Add(line);
                }
                reader.Close();
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine("Could not find file!" + fnf.Message);
            }
        }

        public void LoadZombies()
        {
            // Get a directory of ALL files
            string[] files = Directory.GetFiles(".");
            foreach(string file in files)
            {
                // Only read files containing the string "zombie"
                if(file.Contains("zombie"))
                {
                    StreamReader reader = new StreamReader(File.OpenRead(file));
                    string line = "";
                    string zombieLine;
                    while ((zombieLine = reader.ReadLine()) != null)
                    {
                        line += zombieLine + "\n";
                    }
                    zombies.Add(line);
                    reader.Close();
                }
            }
        }

        public string RandomPhrase()
        {
            // Generate a random phrase with the random class
            int randomPhrase = 0;
            Random random = new Random();
            randomPhrase = random.Next(phrases.Count);
            return phrases[randomPhrase];
        }

        public string RandomZombie()
        {
            // Generate a random zombie with the random class
            int randomZombie = 0;
            Random random = new Random();
            randomZombie = random.Next(zombies.Count);
            return zombies[randomZombie];
        }
    }
}
