﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_Semestralny
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SzkolaEntities : DbContext
    {
        public SzkolaEntities()
            : base("name=SzkolaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Grupa> Grupas { get; set; }
        public virtual DbSet<Oceny> Ocenies { get; set; }
        public virtual DbSet<Prowadzacy> Prowadzacies { get; set; }
        public virtual DbSet<Przedmioty> Przedmioties { get; set; }
        public virtual DbSet<Uczniowie> Uczniowies { get; set; }
    }
}