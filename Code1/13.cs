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
            Console.WriteLine("a = " + a + " b = " + b);
            Console.WriteLine("a<b ... " + (a < b));
            Console.WriteLine("a>b ... " + (a > b));
            Console.WriteLine("a==b ... " + (a == b));
            Console.WriteLine("a=b ... " + (a = b));

        }
    }
}

//a = 10 b = 20
//a < b... True
//a>b ... False
//a==b ... False
//a=b ... 20