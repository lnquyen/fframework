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
    
    public partial class PHAN_CONG_GIANG_DAY_CHI_TIET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHAN_CONG_GIANG_DAY_CHI_TIET()
        {
            this.GV_GIANG_DAY = new HashSet<GV_GIANG_DAY>();
        }
    
        public long PCGDCT_ID { get; set; }
        public Nullable<long> PCGD_ID { get; set; }
        public Nullable<long> LHP_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GV_GIANG_DAY> GV_GIANG_DAY { get; set; }
        public virtual LOP_HOC_PHAN LOP_HOC_PHAN { get; set; }
        public virtual PHAN_CONG_GIANG_DAY PHAN_CONG_GIANG_DAY { get; set; }
    }
}
