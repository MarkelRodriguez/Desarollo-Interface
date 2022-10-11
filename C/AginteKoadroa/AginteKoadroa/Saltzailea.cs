using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AginteKoadroa
{
    public partial class Saltzailea
    {
        [Key]
        public String Id { get; set; }

        public String Izena { get; set; }

        public String Taldea { get; set; }


        public virtual List<Bezeroa> Bezeroa { get; set; }
    }
}
