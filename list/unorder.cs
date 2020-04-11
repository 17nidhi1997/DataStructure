using System;
using System.IO;
namespace fileorder
{
    class unordred
    {
        public void unorderlist()
        {
            string filepath = @"C:\Users\Srinidhi\source\repos\fileorder\fileorder\bin\Debug\netcoreapp3.1\test.txt";
            string[] strarr = File.ReadAllText(filepath).Split(" ");
            List1<string> lines = new List1<string>();
           
            for (int i = 0; i < strarr.Length; i++)
            {
                string wd = strarr[i];
                lines.Add(wd);                             
            }
            string origfile = File.ReadAllText(filepath);
            Console.WriteLine("Enter word to be searched");
            string word = Console.ReadLine();
            if (lines.Search(word)==true)
            {
               
                lines.Delete(word);
            }
           
            else
            {
                
                lines.Add(word);
            }
            Console.WriteLine("After processing final list is as below and your file is modified ");  
            string textFile = lines.ReturnString();
            File.WriteAllText(@"C:\Users\Srinidhi\source\repos\fileorder\fileorder\bin\Debug\netcoreapp3.1\test.txt", textFile);
             lines.ShowNodes();
        }
    }
}
