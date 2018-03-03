using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Circle
    {
        int r;
        double l;
        double area;
        public Circle()
        {
            r = 10;
            area = Math.PI *r *r;
            l = Math.PI *2 *r;
        }
        
        public void findarea()
        {
            area = Math.PI * r * r;
            Console.WriteLine(Math.PI *r *r);
        }
        public void findlength()
        {
            l = Math.PI *2 *r;
            Console.WriteLine(Math.PI *2 *r);
        }
        public override string ToString()
        {
            return l + "\n" + r + "\n" + area;
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Circle r = new Circle();
            r.findarea();
            r.findlength();
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
