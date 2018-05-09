using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static public bool is_prime(int a)
        {
            for(int i = 2; i*i<= a; i++)
            {
                if (a % i == 0)                
                    return false;        

            }
            return true;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\user\Desktop\final\dlya2.txt", FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            string[] arr = line.Split(' ');
            int n = int.MinValue;
            foreach(string str in arr)
            {
                if (is_prime(int.Parse(str)))
                    Console.WriteLine("True");
                
                else
                    Console.WriteLine(is_prime(int.Parse(str)));
            }
            sr.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
