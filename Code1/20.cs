using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1
{
    class CheckedSample
    {
        public static void Main() {
            int a, b;
            try {
                checked {
                    a = int.MaxValue;
                    b = a + 1;
                    Console.WriteLine(b);
                }

            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
       }     
    }
}

//산술 연산으로 인해 오버플로가 발생했습니다.