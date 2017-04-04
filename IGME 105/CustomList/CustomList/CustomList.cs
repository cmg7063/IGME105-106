using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class CustomList
    {
        private int count;
        private String[] data;

        public int Count
        {
            get { return count; }
        }

        public CustomList(int arrayNum)
        {
            data = new String[arrayNum];
        }

        public CustomList(): this(4)
        {
        }

        public void Add (String item)
        {
            if (count == data.Length)
            {
                String[] temp = new String[count * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            data[count] = item;
            count++;
        }

        public String GetData (int index)
        {
            if (index < count && index >= 0)
            {
                return data[index];
            }
            else
            {
                return null;
            }
        }

        public void SetData (int index, String item)
        {
            if (index < count && index >= 0)
            {
                data[index] = item;
            }
        }
        // This returns nothing!? Why??? -- Because I need to Console.WriteLine() the method... duhHHHh
        public int IndexOf (String item)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains (String item)
        {
            if (IndexOf(item) == -1)
            {
                return false;
            }
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index < count && index >= 0)
            {
                Array.Copy(data, index + 1, data, index, Count - (index + 1));
                count--;
            }
        }

        public bool Remove(String item)
        {
            if (data.Contains(item))
            {
                int index = Array.IndexOf(data, item);
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public void Insert (int index, String item)
        {
            if (count > data.Length)
            {
                String[] temp = new String[count * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            Array.Copy(data, index, data, index + 1, Count - index);
            data[index] = item;
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
