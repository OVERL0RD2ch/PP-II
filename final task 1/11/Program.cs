using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {


        static void Main(string[] args)
        {
            int n = 0;
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            string s1 = Convert.ToString(arr);
            //int a = int.Parse(s1);
            int b = 0;
            foreach (string str in arr)
            {
                n++;
            }
            foreach (string str in arr)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string rst = swap(str[0], str[i]);

                    if(str == rst)
                    {
                        b++;
                    }
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
    
}
