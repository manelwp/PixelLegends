//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceJocMP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class armadura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public armadura()
        {
            this.jugadors = new HashSet<jugador>();
        }
    
        public int id { get; set; }
        public string nom { get; set; }
        public double defensa { get; set; }
        public double defensa_especial { get; set; }
        public int id_personatge { get; set; }
    
        public virtual personatge personatge { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jugador> jugadors { get; set; }
    }
}
