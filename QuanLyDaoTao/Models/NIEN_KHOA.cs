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
    
    public partial class NIEN_KHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NIEN_KHOA()
        {
            this.CHUONG_TRINH_DAO_TAO = new HashSet<CHUONG_TRINH_DAO_TAO>();
            this.CHUONG_TRINH_DAO_TAO1 = new HashSet<CHUONG_TRINH_DAO_TAO>();
            this.KHOA_HOC_NIEN_KHOA = new HashSet<KHOA_HOC_NIEN_KHOA>();
            this.PHAN_CONG_GIANG_DAY = new HashSet<PHAN_CONG_GIANG_DAY>();
        }
    
        public long NK_ID { get; set; }
        public string NK_TEN { get; set; }
        public Nullable<int> NK_NAM_BAT_DAU { get; set; }
        public Nullable<int> NK_NAM_KET_THUC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG_TRINH_DAO_TAO> CHUONG_TRINH_DAO_TAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG_TRINH_DAO_TAO> CHUONG_TRINH_DAO_TAO1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOA_HOC_NIEN_KHOA> KHOA_HOC_NIEN_KHOA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHAN_CONG_GIANG_DAY> PHAN_CONG_GIANG_DAY { get; set; }
    }
}
