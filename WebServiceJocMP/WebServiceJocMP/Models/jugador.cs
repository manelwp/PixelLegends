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
    
    public partial class jugador
    {
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
    
        public virtual arma arma { get; set; }
        public virtual armadura armadura { get; set; }
        public virtual personatge personatge { get; set; }
        public virtual usuari usuari { get; set; }
    }
}
