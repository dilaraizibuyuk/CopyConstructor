using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Toplama topla = new Toplama(3,5);
            Toplama t2 = new Toplama(topla);
            Console.WriteLine(t2.islem());
            topla.s1 = 2;
            topla.s2 = 3;
            Console.WriteLine(topla.islem());
            Console.ReadKey();
        }
    }
}
