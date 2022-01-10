using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Toplama
    {
        public int s1;
        public int s2;
        public Toplama()
        {
            s1 = -1;
            s2 = -1;
        }
        public Toplama(int a, int b)
        {
            s1 = a;
            s2 = b;
        }

        public Toplama(Toplama t)
            {
            s1=t.s1;
            s2 = t.s2;

            }

        public int islem()
        {
            return s1 + s2;
        }
            
}
    }

