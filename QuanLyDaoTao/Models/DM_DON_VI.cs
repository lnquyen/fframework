//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDaoTao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_DON_VI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_DON_VI()
        {
            this.DM_DON_VI1 = new HashSet<DM_DON_VI>();
            this.DM_MON_HOC = new HashSet<DM_MON_HOC>();
            this.DM_NGANH = new HashSet<DM_NGANH>();
            this.GIANG_VIEN = new HashSet<GIANG_VIEN>();
            this.GV_DON_VI = new HashSet<GV_DON_VI>();
        }
    
        public long DV_ID { get; set; }
        public string DV_MA { get; set; }
        public string DV_TEN { get; set; }
        public Nullable<long> DV_CHA_ID { get; set; }
        public string DV_GHI_CHU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_DON_VI> DM_DON_VI1 { get; set; }
        public virtual DM_DON_VI DM_DON_VI2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_MON_HOC> DM_MON_HOC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_NGANH> DM_NGANH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIANG_VIEN> GIANG_VIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GV_DON_VI> GV_DON_VI { get; set; }
    }
}
