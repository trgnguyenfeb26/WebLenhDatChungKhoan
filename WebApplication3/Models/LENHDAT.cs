//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LENHDAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LENHDAT()
        {
            this.LENHKHOP = new HashSet<LENHKHOP>();
        }
    
        public int ID { get; set; }
        public string MACP { get; set; }
        public System.DateTime NGAYDAT { get; set; }
        public string LOAIGD { get; set; }
        public string LOAILENH { get; set; }
        public int SOLUONG { get; set; }
        public double GIADAT { get; set; }
        public string TRANGTHAILENH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LENHKHOP> LENHKHOP { get; set; }
    }
}
