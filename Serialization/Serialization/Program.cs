using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Complex
    {
        int x;
        int y;
        public Complex(int a, int b)
        {
            x = a;
            y = b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(3, 5);
        }

        static void F1(Complex c) {
            FileStream fs = new FileStream(@"C:\eula.1028.txt", FileMode.Open, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(fs, c);
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
