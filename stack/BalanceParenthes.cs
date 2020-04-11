using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackpro
{
    using System;
    class BalanceParentheses
    {

        public void IsBalanceParentheses()
        {
            bool valid = false;
            Console.WriteLine("Enter Arithmetic Expression:");
            string expression = Console.ReadLine();
            char[] charArray = expression.ToCharArray();
            int size = charArray.Length;
            for (int j = 0; j < size; j++)
            {
                if (charArray[j] == '(' || charArray[j] == '{' || charArray[j] == '[' || charArray[j] == ')' || charArray[j] == '}' || charArray[j] == ']')
                {
                    valid = true;
                    break;
                }
            }
            if (valid)
            {
                Stack<char> stac = new Stack<char>(size);
                int i = 0;
                while (i < size)
                {
                    if (charArray[i] == '(' || charArray[i] == '{' || charArray[i] == '[')
                    {
                        stac.Push(charArray[i]);
                    }
                    else if (charArray[i] == ')' || charArray[i] == '}' || charArray[i] == ']')
                    {
                        stac.Pop();
                    }
                    i++;
                }
                if (stac.Count == 0)
                {
                    Console.WriteLine("parentheses appeared in a balanced fashion");
                }
                else
                {
                    Console.WriteLine("parentheses are not appeared in a balanced fashion");
                }
            }
            else
            {
                Console.WriteLine("there is no parentheses!!!");
            }
        }
    }
}
