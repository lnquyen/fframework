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
    
    public partial class DM_MON_HOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_MON_HOC()
        {
            this.CHUONG_TRINH_DAO_TAO_CHI_TIET = new HashSet<CHUONG_TRINH_DAO_TAO_CHI_TIET>();
            this.LOP_HOC_PHAN = new HashSet<LOP_HOC_PHAN>();
            this.MH_TIEN_QUYET = new HashSet<MH_TIEN_QUYET>();
            this.MH_TIEN_QUYET1 = new HashSet<MH_TIEN_QUYET>();
        }
    
        public long MH_ID { get; set; }
        public string MH_MA { get; set; }
        public string MH_TEN { get; set; }
        public Nullable<int> MH_SO_TIN_CHI { get; set; }
        public Nullable<int> MH_SO_LY_THUYET { get; set; }
        public Nullable<int> MH_SO_THUC_HANH { get; set; }
        public Nullable<long> HDT_ID { get; set; }
        public Nullable<long> DV_ID { get; set; }
        public string MH_GHI_CHU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG_TRINH_DAO_TAO_CHI_TIET> CHUONG_TRINH_DAO_TAO_CHI_TIET { get; set; }
        public virtual DM_DON_VI DM_DON_VI { get; set; }
        public virtual DM_HE_DAO_TAO DM_HE_DAO_TAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_HOC_PHAN> LOP_HOC_PHAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_TIEN_QUYET> MH_TIEN_QUYET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MH_TIEN_QUYET> MH_TIEN_QUYET1 { get; set; }
    }
}
