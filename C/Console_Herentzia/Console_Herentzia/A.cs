using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Herentzia
{
    internal class A
    {
        public string prop1 { get; set; }
        public virtual string prop2 { get; set; }


        public virtual void Erakutsi()
        {
            Console.WriteLine("A Klasea");
            Console.WriteLine("(0), (1)", prop1, prop2);
        }

    }
}
