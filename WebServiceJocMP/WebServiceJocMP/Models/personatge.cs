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

    public partial class personatge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personatge()
        {
            this.armas = new HashSet<arma>();
            this.armaduras = new HashSet<armadura>();
            this.jugadors = new HashSet<jugador>();
        }

        public int id { get; set; }
        public string nom { get; set; }
        public Nullable<double> vida { get; set; }
        public Nullable<double> atac { get; set; }
        public Nullable<double> atac_especial { get; set; }
        public Nullable<double> defensa { get; set; }
        public Nullable<double> defensa_especial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arma> armas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<armadura> armaduras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jugador> jugadors { get; set; }

    }
}