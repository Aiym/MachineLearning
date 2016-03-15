using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1complex
{
    class complex
    {
        int a, b;
        public complex()
        {
            a = 0;
            b = 1;
        }
        public complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static complex operator +(complex a, complex b)
        {
            return new complex(a.a * b.b + a.b * b.a, a.b * b.b);
        }
        public override string ToString()
        {
            string s = a + "/" + b;
            return s;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            complex a = new complex(7, 9);
            complex b = new complex(8, 4);
            complex c = a + b;
            Console.WriteLine(c.ToString());
        }
    }
}
