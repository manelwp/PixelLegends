﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JocMPEntities : DbContext
    {
        public JocMPEntities()
            : base("name=JocMPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<arma> armas { get; set; }
        public virtual DbSet<armadura> armaduras { get; set; }
        public virtual DbSet<jugador> jugadors { get; set; }
        public virtual DbSet<monstre> monstres { get; set; }
        public virtual DbSet<personatge> personatges { get; set; }
        public virtual DbSet<usuari> usuaris { get; set; }
    }
}
