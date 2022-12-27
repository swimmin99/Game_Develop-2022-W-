using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1
{
    internal class Number
    {
        public static void Main()
        {
            int[,] a = { { 10, 20 }, { 30, 40 }, { 50, 60 } };
            a[1, 1] = 0;
            Console.WriteLine("a[0,0]=" + a[0, 0] + '\t' + "a[0,1] = " + a[0,1]);
            Console.WriteLine("a[1,0]=" + a[1, 0] + '\t' + "a[1,1] = " + a[1, 1]);
            Console.WriteLine("a[2,0]=" + a[2, 0] + '\t' + "a[2,1] = " + a[2, 1]);
        }
    }
}

//a[0, 0] = 10       a[0, 1] = 20
//a[1, 0] = 30       a[1, 1] = 0
//a[2, 0] = 50       a[2, 1] = 60