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
    
    public partial class Grupa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grupa()
        {
            this.Uczniowies = new ObservableCollection<Uczniowie>();
        }
    
        public string Nazwa_Grupy { get; set; }
        public int Rok { get; set; }
        public string Kierunek { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<Uczniowie> Uczniowies { get; set; }
    }
}
