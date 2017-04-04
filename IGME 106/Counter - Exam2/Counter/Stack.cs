using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Stack : IStack
    {
        private List<string> words = new List<string>();

        bool IStack.IsEmpty()
        {
            if(words.Count == 0)
            {
                return true;
            }
            return false;
        }

        string IStack.Pop()
        {
            // Get the last value
            string lastValue = words.Last();

            // Remove it from the list
            words.Remove(lastValue);

            // Return the value
            return lastValue;
        }

        void IStack.Push(string str)
        {
            // Add word to the end of the list
            words.Add(str);
        }
    }
}
