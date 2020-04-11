using System;
using System.Collections.Generic;
using System.Text;

namespace stackPrimeAnnagram
{
    class PrimeNumbers
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
            StackUsingLinkedlist obj = new StackUsingLinkedlist();
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
                        obj.push(prime[j]);
                        index++;
                        anagram[index] = prime[k];
                        obj.push(prime[k]);
                        index++;
                    }

                }
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("Prime anagram number using Stack linkedList :");
            Console.WriteLine();
            obj.display();
           
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

        public class StackUsingLinkedlist
        {

            // A linked list node  
            private class Node
            {
                // integer data  
                public int data;

                // reference variable Node type  
                public Node link;
            }

            // create global top reference variable  
            Node top;

            // Constructor  
            public StackUsingLinkedlist()
            {
                this.top = null;
            }

            // Utility function to add  
            // an element x in the stack  
            // insert at the beginning  
            public void push(int x)
            {
                // create new node temp and allocate memory  
                Node temp = new Node();

                // check if stack (heap) is full.  
                // Then inserting an element 
                // would lead to stack overflow  
                if (temp == null)
                {
                    Console.Write("\nHeap Overflow");
                    return;
                }

                // initialize data into temp data field  
                temp.data = x;

                // put top reference into temp link  
                temp.link = top;

                // update top reference  
                top = temp;
            }

            public void display()
            {
                // check for stack underflow  
                if (top == null)
                {
                    Console.Write("\nStack Underflow");
                    return;
                }
                else
                {
                    Node temp = top;
                    while (temp != null)
                    {

                        // print node data  
                        Console.Write("{0}->", temp.data);

                        // assign temp link to temp  
                        temp = temp.link;
                    }
                }
            }
        }
    }
}
