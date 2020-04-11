using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Bank
    {
        public int balance;

    }
    public class Node
    {
        public string Name;
        public int balance;
        public Node next;
        public Node(string Name)
        {
            this.Name = Name;
        }
    }
    class QueueUtility
    {
        Node front, rear;
        Bank bank = new Bank();
        public void AddMoneyRecords(Bank newNode)
        {
            this.bank.balance = newNode.balance;
        }
        public void ShowCustomerStatus(Node newNode)
        {
            QueueUtility utility = new QueueUtility();
            Console.WriteLine("Customer Name=" + newNode.Name +
                "\n Customer Balance=" + newNode.balance);
        validTwo:
            Console.WriteLine("1.Deposite \n2.Withdrawal \n" + "3.exit\n" +
               "4.Bank Status \nenter your option.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("enter amount to deposite:");
                    int deposite = Convert.ToInt32(Console.ReadLine());
                    newNode.balance += deposite;
                    bank.balance += newNode.balance;
                    utility.AddMoneyRecords(bank);
                    utility.ShowCustomerStatus(newNode);
                    break;

                case 2:
                    Console.WriteLine("enter amount to withdrawal:");
                    int withdrawal = Convert.ToInt32(Console.ReadLine());
                    newNode.balance -= withdrawal;
                    bank.balance -= newNode.balance;
                    utility.AddMoneyRecords(bank);
                    utility.ShowCustomerStatus(newNode);
                    break;

                case 3:
                    utility.Dequeue();
                    Console.WriteLine("customer is out of the queue.");
                    break;

                case 4:
                    Console.WriteLine("Bank Balance=" + this.bank.balance);
                    goto validTwo;

                default:
                    Console.WriteLine("invalid input!! enter your option again:");
                    goto validTwo;
            }
        }
        public void EnQueue(string Name, int balance)
        {
            this.bank.balance = 10000000;
            QueueUtility utility = new QueueUtility();
            Node newNode = new Node(Name);
            newNode.balance = balance;
            //bank.balance += newNode.balance;
            //utility.AddMoneyRecords(bank);
            if (rear == null)
            {
                front = rear = newNode;
            }
            rear.next = newNode;
            rear = newNode;
            Console.WriteLine("1.Deposite \n2.Withdrawal \n" +
                "enter your option.");
        validOne:
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("enter amount to deposite:");
                    int deposite = Convert.ToInt32(Console.ReadLine());
                    newNode.balance += deposite;
                    bank.balance += newNode.balance;
                    utility.AddMoneyRecords(bank);
                    utility.ShowCustomerStatus(newNode);
                    break;

                case 2:
                    Console.WriteLine("enter amount to withdrawal:");
                    int withdrawal = Convert.ToInt32(Console.ReadLine());
                    newNode.balance -= withdrawal;
                    bank.balance -= newNode.balance;
                    utility.AddMoneyRecords(bank);
                    utility.ShowCustomerStatus(newNode);
                    break;
                default:
                    Console.WriteLine("invalid input!! enter your option again:");
                    goto validOne;
            }
        }

        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            front = front.next;
            Console.WriteLine("Element is deleted");
            if (front == null)
            {
                rear = null;
            }
        }

        public void DisplayQueue()
        {
            Node current = front;

            if (current == null)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                while (current != null)
                {
                    Console.Write(current.Name + "-->");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }

