using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static bool prime(int n)
        {
            if (n <= 2)
            {
                return false;
            }
            for (int i=2; i <= Math.Sqrt(n); i++)
            { 
                if (n % i == 0)
                    return false;
                
            }
            else return true;
        }
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] values = line.Split(' ');
            for ( int i = 0; i<values.Length; i++)
            {
                if (prime(int.Parse(values[i])))
                    Console.WriteLine(values[i]);
            }
            Console.ReadKey();


        }
    }
}
