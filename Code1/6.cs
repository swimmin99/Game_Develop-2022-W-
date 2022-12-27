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
            Console.WriteLine(a[1, 0]);
        }
    }
}

//30