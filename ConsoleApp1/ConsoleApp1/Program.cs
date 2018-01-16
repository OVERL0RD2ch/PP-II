using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime 
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(' ');

            for (int i = 2; i < arr.Length; i++)
            {if(arr[i])


                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}