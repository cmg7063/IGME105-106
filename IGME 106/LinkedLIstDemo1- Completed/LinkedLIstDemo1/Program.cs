using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLIstDemo1
{
    // test class
    class Program
    {
        static void Main(string[] args)
        {
            // create a linked list
            MyLinkedList list = new MyLinkedList();

            // populate the list
            list.Add("This");
            list.Add("is");
            list.Add("a");
            list.Add("test");
            list.Add("of");
            list.Add("a");
            list.Add("linked");
            list.Add("list");

            // traverse the list
            list.Traverse();

            // use GetData to print strings from list
            Console.WriteLine("String: " + list.GetData(2));
            Console.WriteLine("String: " + list.GetData(3));
            Console.WriteLine("String: " + list.GetData(4));
            Console.WriteLine("String: " + list.GetData(5));
            Console.WriteLine("String: " + list.GetData(6));
            Console.WriteLine("String: " + list.GetData(7));
            Console.WriteLine("String: " + list.GetData(0));
            Console.WriteLine("String: " + list.GetData(1));
        }
    }
}
