using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE22
{
    class Tree
    {
        // Attributes
        private Node root = null;

        // Properties
        public Node Root
        {
            get { return root; }
        }

        public void Insert(int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                Insert(data, root);
            }
        }

        // Private insert method
        private void Insert(int data, Node node)
        {
            if (data < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(data);
                }
                else
                {
                    Insert(data, node.Left);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(data);
                }
                else
                {
                    Insert(data, node.Right);
                }
            }
        }
        // Public easy print ethod
        public void Print()
        {
            Print(root, 0);
        }

        // Private print method
        private void Print(Node node, int level)
        {
            if (node != null)
            {
                Print(node.Right, level + 1);
                for (int i = 0; i < level; i++)
                {
                    Console.Write("|");
                }
                Console.WriteLine(node.Data);
                Print(node.Left, level + 1);
            }
        }
    }
}
