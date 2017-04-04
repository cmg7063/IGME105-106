using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomQueue
{
    class GameQueue : IQueue
    {
        private string[] data = new string[0];

        public int Count
        {
            get
            {
                return data.Length;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if(data.Length == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public string Dequeue()
        {
            string topValue = data[0];
            string[] newData = new string[data.Length - 1];

            for (int i = 0; i < data.Length - 1; i++)
            {
                newData[i] = data[i + 1];
            }
            data = newData;
            return topValue;
        }

        public void Enqueue(string str)
        {
            string[] newData = new string[data.Length + 1];

            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            newData[newData.Length - 1] = str;
            data = newData;
        }

        public string Peek()
        {
            return data[0];
        }
    }
}
