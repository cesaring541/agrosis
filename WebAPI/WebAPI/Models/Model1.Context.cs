﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AGROSISEntities : DbContext
    {
        public AGROSISEntities()
            : base("name=AGROSISEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<clntes> clntes { get; set; }
        public virtual DbSet<clntes_drccnes> clntes_drccnes { get; set; }
        public virtual DbSet<det_vles_drccnes> det_vles_drccnes { get; set; }
        public virtual DbSet<det_vles_prsnas> det_vles_prsnas { get; set; }
        public virtual DbSet<det_vles_srvcios> det_vles_srvcios { get; set; }
        public virtual DbSet<det_vles_vhclos> det_vles_vhclos { get; set; }
        public virtual DbSet<enc_vles> enc_vles { get; set; }
        public virtual DbSet<mnnto_vhclos> mnnto_vhclos { get; set; }
        public virtual DbSet<prsnas> prsnas { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<cntros> cntros { get; set; }
        public virtual DbSet<enc_vles_bck> enc_vles_bck { get; set; }
        public virtual DbSet<lstas_prcio> lstas_prcio { get; set; }
        public virtual DbSet<mvmnto_vhclos> mvmnto_vhclos { get; set; }
        public virtual DbSet<prfles_usrio> prfles_usrio { get; set; }
        public virtual DbSet<prsnas_drccnes> prsnas_drccnes { get; set; }
        public virtual DbSet<prsnas_eps> prsnas_eps { get; set; }
        public virtual DbSet<prsnas_fndos_pnsnes> prsnas_fndos_pnsnes { get; set; }
        public virtual DbSet<prsnas_obsrvcnes> prsnas_obsrvcnes { get; set; }
        public virtual DbSet<prsnas_tlfnos> prsnas_tlfnos { get; set; }
        public virtual DbSet<usrios> usrios { get; set; }
        public virtual DbSet<usrios_clves> usrios_clves { get; set; }
    }
}
