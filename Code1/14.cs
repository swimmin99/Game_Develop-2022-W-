using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1
{
    internal class Compare
    {
        public static void Main()
        {
            int a = 10, b = 20;
            bool c, d, e;

            c = a < b;
            d = a > b;
            e = a == b;
            Console.WriteLine("a = " + a + " b = " + b);
            Console.WriteLine("a<b ... " + c);
            Console.WriteLine("a>b ... " + d);
            Console.WriteLine("a==b ... " + e);

        }
    }
}
//a = 10 b = 20
//a < b... True
//a>b ... False
//a==b ... False