using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class monstre
    {
        public monstre()
        {

        }

        public int id { get; set; }
        public string nom { get; set; }
        public double vida { get; set; }
        public double atac { get; set; }
        public double atac_especial { get; set; }
        public double defensa { get; set; }
        public double defensa_especial { get; set; }
    }
}
