using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code1
{
    internal class Enumsample
    {
        enum Animal {  mouse, cat, bird, dog = 100, koala, pig = 200, lion};
        public static void Main()
        {
            Animal a;
            a = Animal.dog;

            Console.WriteLine(Animal.cat);
            Console.WriteLine((int)Animal.dog);
            Console.WriteLine((int)Animal.lion);
            Console.WriteLine(a);

        }
    }
}

//cat
//100
//201
//dog