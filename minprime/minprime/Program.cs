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
        static bool prime(int n)
        {
            if (n <=2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
            static void Main(string[] args)
        {
            StreamReader file1 = new StreamReader(@"C:\test\file1.txt");
            string s = file1.ReadLine();
            file1.Close();
            string[] s1 = s.Split(' ');
            int n;
            int min = 1000000000;
            for (int i = 0; i < s1.Length; i++)
            {
                n = int.Parse(s1[i]);
                if (prime(n) && min > n)                  
                    min = n;
            }
            Console.WriteLine("Min prime" + " = " + min);
            StreamWriter file2 = new StreamWriter(@"C:\test\file2.txt");
            file2.WriteLine("Min prime" + " = " + min);
            file2.Close();
            Console.ReadKey();







        }
        


        
    }

}
