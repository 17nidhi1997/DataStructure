using System;
using System.Collections.Generic;
using System.Text;

namespace queueLinklist
{
    class queueLinklist
    {
        public void CheckPrime()
        {
            int[] prime = new int[200];
            prime[0] = 2;
            int index = 1, i = 3;
            while (i <= 1000)
            {
                bool valid = false;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        valid = true;
                    }
                }
                if (valid == false)
                {
                    prime[index] = i;
                    index++;
                }
                i++;
            }
            int[] range = new int[] { 0, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
            for (int k = 0; k < range.Length - 1; k++)
            {
                for (int j = 0; j < prime.Length; j++)
                {
                    if (range[k] < prime[j] && range[k + 1] > prime[j])
                    {
                        Console.Write(prime[j] + " ");
                    }
                }
                Console.WriteLine();
            }
            int[] anagram = new int[100];
            LinkListQueue obj = new LinkListQueue();
            index = 0;
            for (int j = 0; j < prime.Length; j++)
            {
                int temp = 0, count = prime[j];
                while (count > 0)
                {
                    int r = count % 10;  //getting remainder  
                    temp = (temp * 10) + r;
                    count = count / 10;
                }
                for (int k = j + 1; k < prime.Length; k++)
                {
                    if (prime[k] > temp + 1 || index == 100)
                    {
                        break;
                    }
                    bool valid = IsAnagram(prime[j], prime[k]);
                    if (valid)
                    {
                        anagram[index] = prime[j];
                        obj.Enqueue(prime[j]);
                        index++;
                        anagram[index] = prime[k];
                        obj.Enqueue(prime[k]);
                        index++;
                    }

                }
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("Prime anagram number using  linkedList :");
            Console.WriteLine();
            obj.Display();

        }

        public bool IsAnagram(int firstInput, int secondInput)
        {
            string string1 = Convert.ToString(firstInput);
            string string2 = Convert.ToString(secondInput);
            char[] charArray1 = string1.ToCharArray();
            char[] charArray2 = string2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            string resultString1 = new string(charArray1);
            string resultString2 = new string(charArray2);
            int result = string.Compare(resultString1, resultString2);
            if (result == 0)

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public class LinkListQueue
        {
            public class Node
            {
                public int data;
                public Node next;

                // Constructor to create a new node.Next is by default initialized as null  
                public Node(int d)
                {
                    data = d;
                    next = null;
                }
            }

            Node front;
            Node rear;

            public LinkListQueue()
            {
                this.front = this.rear = null;
            }


            public void Enqueue(int item)
            {
                Node newNode = new Node(item);

                // If queue is empty, then new node is front and rear both  
                if (this.rear == null)
                {
                    this.front = this.rear = newNode;
                }
                else
                {
                    // Add the new node at the end of queue and change rear  
                    this.rear.next = newNode;
                    this.rear = newNode;
                }
               
            }


            public void Dequeue()
            {
                // If queue is empty, return NULL.  
                if (this.front == null)
                {
                    Console.WriteLine("The Queue is empty");
                    return;
                }

                // Store previous front and move front one node ahead  
                Node temp = this.front;
                this.front = this.front.next;

                // If front becomes NULL, then change rear also as NULL  
                if (this.front == null)
                {
                    this.rear = null;
                }

                Console.WriteLine("Item deleted is {0}", temp.data);
            }

            public void Display()
            {
                Node temp = this.front;
                if ((this.front == null) && (this.rear == null))
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                Console.WriteLine("Queue elements are: ");
                while (temp != null)
                {
                    Console.Write("{0}->" ,temp.data);
                    temp = temp.next;
                }
         
            }
        }
    }
}
