//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCC.Dropper.Repositorio
{
    using System;
    using System.Collections.Generic;
    
    public partial class SENSOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SENSOR()
        {
            this.VAZAO = new HashSet<VAZAO>();
        }
    
        public int ID_SENSOR { get; set; }
        public string DESCRICAO { get; set; }
        public bool ENTRADA_GLOBAL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VAZAO> VAZAO { get; set; }
    }
}
