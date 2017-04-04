using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Queue : IQueue
    {
        private List<string> words = new List<string>();

        public string Dequeue()
        {
            // Remove irst item in list and then return it
            string topValue = words[0];
            words.RemoveAt(0);
            return topValue;

        }

        public void Enqueue(string str)
        {
            words.Add(str);
        }

        public bool IsEmpty()
        {
            if (words.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
