using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Triangle
    {
        int a;
        int b;
        int c;
        double area;
        int perimetr;
        public Triangle()
        {
            a = 4;
            b = 4;
            c = 4;
        }
        public Triangle(int q, int w, int e)
        {
            a = q;
            b = w;
            c = e;
        }
        public void TriangleArea()
        {
            int p = (a +b +c)/2;
            area = Math.Sqrt(p *(p - a) *(p - b) *(p - c));
        }
        public void TrianglePerimetr()
        {
            perimetr = a +b +c;
        }
        public override string ToString()
        {
            return a + "\n" + b + "\n" + c + "\n" + area + "\n" + perimetr;
        }
    }

}
