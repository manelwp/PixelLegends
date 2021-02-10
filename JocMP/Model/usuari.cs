using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class usuari
    {

        public usuari()
        {
        }
        public int id { get; set; }
        public string nom { get; set; }
        public string contrasenya { get; set; }
        public byte secret { get; set; }
    }
}
