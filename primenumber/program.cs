using System;
using System.Collections.Generic;
using System.Text;

namespace stackPrimeAnnagram
{
    class Program
    {
        static void Main(string[] args)
          {
            Console.WriteLine("****************************prime numbers*****************************");
            Console.WriteLine("1.using queue linklist \n2.PrimeNumbers\nSelect your options: \n3:using stacklinklist");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
     case 1:queueLinklist aa = new queueLinklist();
            aa.CheckPrime();
            break;
     case 2:PrimeNumbers numbers = new PrimeNumbers();
            numbers.CheckPrime();
            break;  

     case 3:PrimeNumbers numbers = new PrimeNumbers();
            numbers.CheckPrime();
            break;
            Console.ReadKey();
        }           

    }
}
