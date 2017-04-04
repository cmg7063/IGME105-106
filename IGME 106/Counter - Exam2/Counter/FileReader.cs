using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Counter
{
    class FileReader
    {
        private Queue queue = new Queue();

        public Queue Queue
        {
            get { return queue; }
        }

        public void ReadData()
        {
            try
            {
                StreamReader reader = new StreamReader(File.OpenRead("book.txt"));
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string [] words = line.Split(' ');
                    for(int i = 0; i < words.Length; i++)
                    {
                        queue.Enqueue(words[i]);
                    }
                }
                // Close file
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
