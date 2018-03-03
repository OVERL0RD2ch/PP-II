using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file1 = new StreamReader(@"C:\test\file1.txt");
            string s = file1.ReadLine();
            string[] s1 = s.Split(' ');
            int n;
            int max = -1000000000;
            int min = 1000000000;
            for (int i = 0; i < s1.Length; i++)
            {
                n = int.Parse(s1[i]);
                if (max < n)
                    max = n;
                if (min > n)
                    min = n;
            }
            Console.WriteLine("Max" + " = " + max + "\n" + "Min" + " = " + min);
            Console.ReadKey();
        }
    }
    
}
