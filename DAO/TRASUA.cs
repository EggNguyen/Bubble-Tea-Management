//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRASUA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRASUA()
        {
            this.CHITIET_HOADON = new HashSet<CHITIET_HOADON>();
        }
    
        public string TRASUA_MATS { get; set; }
        public string TRASUA_TEN { get; set; }
        public decimal TRASUA_GIA { get; set; }
        public System.DateTime TRASUA_NGAYTAO { get; set; }
        public string TRASUA_MOTA { get; set; }
        public Nullable<byte> TRASUA_TRANGTHAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_HOADON> CHITIET_HOADON { get; set; }
    }
}
