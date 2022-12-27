using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1
{
    internal class Position
    {
        public static void Main()
        {
            int a = 1;
            int b = 1;
            Console.WriteLine("전치라면 a는 " + ++a + "가 됩니다.");
            Console.WriteLine("후치라면 b는 " + b++ + "가 됩니다.");
        }
    }
}
//전치라면 a는 2가 됩니다.
//후치라면 b는 1가 됩니다.