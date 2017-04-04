using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class LinkedList : IList
    {
        // Attributes
        Node head;
        Node tail;
        int count;

        // Properties
        public int Count
        {
            get { return count; }
        }

        public void Add(string data)
        {
            Node newNode = new Node(data);
            // If the list is empty,
            if (head == null)
            {
                // Add newNode object to the end of the list
                head = newNode;
                tail = head;
                count++;
            }
            // Handle case where the list is not empty
            else
            {
                // Moves previous node to tail
                newNode.Previous = tail;

                tail = newNode;
                tail.Previous.Next = tail;
                count++;
            }
        }
        public void Insert(string data, int index)
        {
            Node addNode = new Node(data);
            // If index <= 0, add addNode into the list at position zero
            if (index <= 0)
            {
                if (head != null)
                {
                    addNode.Next = head; // Update head
                    head = addNode;
                    head.Next.Previous = head; 
                    count++;
                }
                // Else, add new node at the head
                else
                {
                    head = addNode;
                    count++;
                }
            }
            // If index is >= list count, add new node to end of list
            if (index >= count)
            {
                Add(data);
            }
            else
            {
                Node current = head;
                // Loop through list for index
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                current.Previous.Next = addNode;
                addNode.Previous = current.Previous;
                addNode.Next = current;
                current.Previous = addNode;
                count++;
            }
        }
        public string Remove(int index)
        {
            string remove = "";
            // If an invalid index is given return null
            if (index >= count || index < 0)
            {
                return null;
            }
            else if (index == 0)
            {
                // Update head pointer
                remove = head.Data;
                if (head.Next != null) // If it exists
                {
                    head = head.Next;
                    head.Previous = null; // Set previous node to null
                }
                else
                {
                    head = null;
                }
            }
            // If the index is the last noe in the list
            else if (index == count - 1)
            {
                // Update new tail's node to null
                remove = tail.Data;
                tail = tail.Previous;
                tail.Next = null;
            }
            else // If the index points to a node in the middle of the list
            {
                Node current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                remove = current.Data;
                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;
            }
            // All 3 cases decrease count and return data value from node 
            count--;
            return remove;
        }
        public string GetElement(int index)
        {
            if (index >= count || index < 0)
            {
                return null;
            }
            else
            {
                Node current = head;
                // Loop through list for desired Node
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
        }
        public void Clear()
        {
            count = 0;
            head = null;
            tail = null;
        }
    }
}
