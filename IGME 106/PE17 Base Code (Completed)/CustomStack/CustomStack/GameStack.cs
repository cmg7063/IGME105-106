using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    class GameStack : IStack
    {
        private string[] data;
        private string topValue;
        private string[] dataUpdate;
        int length;

        public int Count
        {
            get { return length; }
        }
        public bool IsEmpty
        {
            get
            {
                if (length == 0)
                {
                    return true;
                }
                return false;
            }
        }
        public void Push(string str)
        {
            dataUpdate = new string[length + 1];

            for (int i = 0; i < length; i++)
            {
                dataUpdate[i] = data[i];
            }
            dataUpdate[length] = str;
            data = new string[length + 1];
            data = dataUpdate;
            length++;
        }
        public string Pop()
        {
            topValue = data[length - 1];
            dataUpdate = new string[length - 1];

            for (int i = 0; i < length - 1; i++)
            {
                dataUpdate[i] = data[i];
            }
            data = new string[length - 1];
            data = dataUpdate;
            length--;
            return topValue;
        }
        public string Peek()
        {
            return data[length - 1];
        }
    }
}
