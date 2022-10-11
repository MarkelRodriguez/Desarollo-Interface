using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa
{
    public partial class Bezeroa
    {
        [Key]
        public String Id { get; set; }
        public String Izena { get; set; }

        public String Helbidea { get; set; }

        public String Telf { get; set; }

        public String Emaila { get; set; }

        public String SaltzaileaId { get; set; }

        public virtual Saltzailea Saltzailea { get; set; }
        public virtual List<Salmenta> Salmenta { get; set; }


    }
}
