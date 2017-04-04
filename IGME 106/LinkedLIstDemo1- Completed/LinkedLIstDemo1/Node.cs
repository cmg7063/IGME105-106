using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLIstDemo1
{
    // one node in singly linked list
    class Node
    {
        // attributes
        private string data; // data to store
        private Node next; // connection to the next node

        // constructor
        public Node(string str)
        {
            data = str;
            next = null;
        }

        // properties
        public string Data
        {
            get { return data;  }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        // override ToString
        public override string ToString()
        {
            string text = "";

            // create the string to return based on next value
            if(next != null) // connected to another node
            {
                text = "Data: " + data + " Next: connected to another node";
            }
            else
            {
                text = "Data: " + data + " Next: NOT connected to another node";
            }

            return text;
        }

    }
}
