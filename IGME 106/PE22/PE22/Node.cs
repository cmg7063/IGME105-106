using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE22
{
    class Node
    {
        // Attributes
        private Node left;
        private Node right;
        private int data;
        
        // Properties
        public Node(int num)
        {
            data = num;
            left = null;
            right = null;
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        public int Data
        {
            get { return data; }
        }
    }
}
