using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1
{
    internal class Judge
    {
        public static void Main()
        {
            string right = "정답", wrong = "오답";
            bool value;

            value = true;
            string answer = value ? right : wrong;
            Console.WriteLine(answer);

            value = false;
            answer = value ? right : wrong;
            Console.WriteLine(answer);
        }
    }
}

//정답
//오답
