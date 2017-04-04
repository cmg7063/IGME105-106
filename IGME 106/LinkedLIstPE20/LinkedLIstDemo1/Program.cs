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
            list.InsertSorted("This");
            list.InsertSorted("is");
            list.InsertSorted("a");
            list.InsertSorted("test");
            list.InsertSorted("of");
            list.InsertSorted("a");
            list.InsertSorted("linked");
            list.InsertSorted("list");

            // traverse the list
            list.Traverse();
        }
    }
}
