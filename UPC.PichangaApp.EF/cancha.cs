//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.PichangaApp.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class cancha
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cancha()
        {
            this.horarios = new HashSet<horario>();
        }
    
        public int id_cancha { get; set; }
        public string nombre { get; set; }
        public int capacidad { get; set; }
        public bool activo { get; set; }
        public decimal precio_alquiler { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<horario> horarios { get; set; }
    }
}
