using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Point
    {
        public int x;
        public int y;
        public Point() { }
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public static Point operator +(Point c1, Point c2)  
        {
            Point p = new Point();
            p.x = c1.x + c2.x;
            p.y = c1.y + c2.y;
            return p;
        }
        public override string ToString()
        {
            return x + " " + y;
        }
        static void Main(string[] args)
        {
            Point c1 = new Point(2, 3);
            Point c2 = new Point(3, 4);
            Point result = c1 + c2;
            Console.WriteLine(result);
            Console.ReadKey();
        }
        
        

        
    }
}
