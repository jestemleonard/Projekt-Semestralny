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
    
    public partial class Prowadzacy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prowadzacy()
        {
            this.Przedmioties = new ObservableCollection<Przedmioty>();
        }
    
        public int Prowadzacy_ID { get; set; }
        public string P_Imie { get; set; }
        public string P_Nazwisko { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<Przedmioty> Przedmioties { get; set; }
    }
}