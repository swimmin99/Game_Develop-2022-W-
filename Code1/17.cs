using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1
{
     class Priority
    {
        public static void Main()
        {
            Console.WriteLine("2 x 8 - 6 / 2 = " + (2 * 8 - 6 / 2));
            Console.WriteLine("2 x (8 - 6) / 2 = " + (2 * (8 - 6) / 2));
            Console.WriteLine("1 - 2 + 3 = " + (1 - 2 + 3));
            Console.WriteLine("1 - (2+3) = " + (1 - (2 + 3)));

        }
    }
}

//2 x 8 - 6 / 2 = 13
//2 x(8 - 6) / 2 = 2
//1 - 2 + 3 = 2
//1 - (2 + 3) = -4