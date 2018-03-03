using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Student
    {
        public string firstName;
        public string lastName;
        public float gpa;

        public Student()
        {
            firstName = "Pavel";
            lastName = "Kozlov";
            gpa = 4;
        }
        public Student(string a, string b, float c)
        {
            firstName = a;
            lastName = b;
            gpa = c;
        }
        public override string ToString()
        {
            return this.firstName + " " + lastName + " " + gpa;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Student a = new Student();

            Console.WriteLine(a);

            Console.ReadKey();

        }
    }
}