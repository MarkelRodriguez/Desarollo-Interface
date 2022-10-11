using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa1
{
    internal class Esaldia
    {
        public string Hitza { get; set; }

        public string EsaldiBatua { get; set; }

        public Esaldia(string hitza, string esaldiBatua)
        {
            this.Hitza = hitza;
            this.EsaldiBatua = esaldiBatua ;
        }

        public Esaldia()
        {

        }
        
       public String Lotu()
        {
            this.EsaldiBatua = EsaldiBatua + Hitza;
            return this.EsaldiBatua;
        }
    }
}
