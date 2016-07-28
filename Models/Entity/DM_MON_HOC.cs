namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_MON_HOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_MON_HOC()
        {
            CHUONG_TRINH_DAO_TAO_CHI_TIET = new HashSet<CHUONG_TRINH_DAO_TAO_CHI_TIET>();
            LOP_HOC_PHAN = new HashSet<LOP_HOC_PHAN>();
            MH_TIEN_QUYET = new HashSet<MH_TIEN_QUYET>();
            MH_TIEN_QUYET1 = new HashSet<MH_TIEN_QUYET>();
        }

        [Key]
        public long MH_ID { get; set; }

        [StringLength(20)]
        public string MH_MA { get; set; }

        [StringLength(255)]
        public string MH_TEN { get; set; }

        public int? MH_SO_TIN_CHI { get; set; }

        public int? MH_SO_LY_THUYET { get; set; }

        public int? MH_SO_THUC_HANH { get; set; }

        public long? HDT_ID { get; set; }

        public long? DV_ID { get; set; }

        [StringLength(255)]
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
