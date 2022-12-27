using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1
{
    internal class Or
    {
        public static void Main()
        {
            int a = 3, b = 4;
            bool x, y;

            x = (a < 0);
            y = (b > 0);
            Console.WriteLine((a == 3) && (b == 3));
            Console.WriteLine(x || y);
        }
    }
}

//False
//True