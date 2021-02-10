using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class armadura
    {

        public armadura()
        { }

        public int id { get; set; }
        public string nom { get; set; }
        public double defensa { get; set; }
        public double defensa_especial { get; set; }
        public int id_personatge { get; set; }
    }
}
