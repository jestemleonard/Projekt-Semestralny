//------------------------------------------------------------------------------
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
    using System.Collections.ObjectModel;
    
    public partial class Oceny
    {
        public int ID_Oceny { get; set; }
        public string Nazwa_Przedmiotu { get; set; }
        public int Ocena { get; set; }
        public int Legitymacja { get; set; }
    
        public virtual Przedmioty Przedmioty { get; set; }
        public virtual Uczniowie Uczniowie { get; set; }
    }
}