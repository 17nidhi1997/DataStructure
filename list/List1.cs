using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileorder
{
   
    /// A simple basic implementation of singly linked list in C#. 
   
    internal class List1<T>
    {
        
        /// Node class
       
        internal class Node
        {
            private string data;
            private Node next = null;

           
            /// Pointer to next node.
           
            internal Node Next
            {
                get { return next; }
                set { next = value; }
            }

           
            /// Data stored in the node.
           
            internal string Data
            {
                get { return data; }
                set { data = value; }
            }

           
            /// Constructor
           
            internal Node(string d)
            {
                data = d;
            }
        }

        private int _length;
        private Node _head;

        
        /// Length of the list
        
        internal int Length
        {
            get { return _length; }
        }

       
        /// Default Constructor
       
        internal List1()
        {
            _length = 0;
            _head = null;
        }

       
        /// Display all nodes.
        
        public void ShowNodes()
        {
            // Print all nodes till the end of the list.
            Node current = _head;
            if (current == null)
            {
                Console.WriteLine("No more nodes to display.");
                Console.WriteLine();
            }
            else
            {
                ShowLength();
                while (current != null)
                {
                    Console.WriteLine("Node : " + current.Data);
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
        public void DisplayIntList()
        {
            Node current = _head;
            if (_head != null)
            {
                while (current != null)
                {
                    Console.Write(current.Data + "-->");
                    current = current.Next;
                }
                Console.Write("null");


                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
        public string ReturnString()
        {
            string stringText = "";
            Node current = _head;
            if (_head != null)
            {
                stringText += current.Data;
                current = current.Next;
                while (current != null)
                {
                    stringText = stringText + " " + current.Data;
                    current = current.Next;
                }
                return stringText;
            }
            else
            {
                Console.WriteLine("List is empty");
                return null;
            }
        }
       
        /// Show length of the list.
        internal void ShowLength()
        {
            string numString = "numbers";
            if (_length == 1)
            {
                numString = "number";
            }
            Console.WriteLine(String.Format("List has [{0}] {1}.", _length.ToString(), numString));
        }

       
        /// To insert a new Node at the end of the list.
       
        internal void Add(string d)
        {
            Console.WriteLine();
            Console.WriteLine(String.Format("Add node [{0}].", d.ToString()));
            // Create a new Node instance with given data;
            Node newNode = new Node(d);
            Node current = _head;
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                // Traverse till the end of the list....
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Add new node as the next node to the last node.
                current.Next = newNode;
            }
            _length++;
            //ShowNodes();
        }

        /// Delete the node matching specified number, if it exists.
        
        internal void Delete(string d)
        {
            Console.WriteLine();
            Console.WriteLine(String.Format("Delete node [{0}].", d.ToString()));
            // Find the node to be deleted. 
            Node current = _head;

            if (current != null)
            {
                // Handle the case for 'head' node when first node matches the node to be deleted.
                if (current.Data == d)
                {
                    // If first node is not the only node
                    if (current.Next != null)
                    {
                        current = current.Next;
                    }
                    else
                    {
                        current = null;
                    }
                    _head = current;
                    _length--;
                }
                else
                {
                    while (current.Next != null && current.Next.Data != d)
                    {
                        current = current.Next;
                    }
                    if (current.Next != null && current.Next.Data == d)
                    {
                        // Set the next pointer of the previous node to be the node next to the one that is being deleted.
                        current.Next = current.Next.Next;
                        // Delete the node
                        current = null;
                        _length--;
                    }
                    else
                    {
                        Console.WriteLine(d.ToString() + " could not be found in the list.");
                    }
                }
            }
            ShowNodes();
        }

       
        /// Find node matching the specified number.
        
        public bool Search(string key)
        {
            Node current = _head;
            if (_head == null)
            {
                Console.WriteLine("List is empty so none element deleted");
                return false;
            }
            while (current.Data != key)
            {
                if (current.Next == null)
                {
                    break;
                }
                current = current.Next;
            }
            if (current.Data == key)
            {
                Console.WriteLine("element found in list");
                return true;
            }
            else
            {
                Console.WriteLine("element is not in list");
                return false;
            }
        }
        public bool Find(string d)
        {
            Console.WriteLine();
            Console.WriteLine(String.Format("Find node [{0}].", d.ToString()));
            Node current = _head;
            if (current != null)
            {
                int counter = 1;
                while (current.Next != null && current.Data != d)
                {
                    current = current.Next;
                    counter++;
                }
                if (current.Data == d)
                {
                    Console.WriteLine(String.Format("Found {0} in the list at position [{1}].", d.ToString(), counter.ToString()));
                    return true;
                }
                else
                {
                    Console.WriteLine(String.Format("{0} was not found in the list.", d.ToString()));
                    return false;
                }
            }
            else
            {
                Console.WriteLine(String.Format("{0} was not found in the list.", d.ToString()));
                return false;
            }
        }
    }
}
