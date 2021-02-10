using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class jugador
    {
        public jugador()
        {
        }

        public int id { get; set; }
        public string nom { get; set; }
        public Nullable<int> nivell { get; set; }
        public Nullable<double> vida { get; set; }
        public Nullable<double> atac { get; set; }
        public Nullable<double> atac_especial { get; set; }
        public Nullable<double> defensa { get; set; }
        public Nullable<double> defensa_especial { get; set; }
        public Nullable<int> id_usuari { get; set; }
        public Nullable<int> id_personatge { get; set; }
        public Nullable<int> id_arma { get; set; }
        public Nullable<int> id_armadura { get; set; }

    }
}
