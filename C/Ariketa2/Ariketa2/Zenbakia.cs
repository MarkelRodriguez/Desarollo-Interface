using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2
{
    internal class Zenbakia
    {

        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }
        public double emaitza { get; set; }


        public Zenbakia(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        } 
        public Zenbakia()
        {

        }

        public double Eragiketa()
        {
            emaitza = (a + 2 * b + 3 * c + 4 * d) / 4;
            return emaitza;
        }

    }
}
