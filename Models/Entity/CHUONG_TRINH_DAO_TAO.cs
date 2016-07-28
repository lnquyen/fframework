namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHUONG_TRINH_DAO_TAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUONG_TRINH_DAO_TAO()
        {
            CHUONG_TRINH_DAO_TAO_CHI_TIET = new HashSet<CHUONG_TRINH_DAO_TAO_CHI_TIET>();
        }

        [Key]
        public long DT_ID { get; set; }

        [StringLength(20)]
        public string DT_MA { get; set; }

        [StringLength(20)]
        public string DT_TEN { get; set; }

        public long? DT_NIEN_KHOA_BAT_DAU { get; set; }

        public long? DT_NIEN_KHOA_KET_THUC { get; set; }

        [StringLength(255)]
        public string DT_GHI_CHU { get; set; }

        public long? NGANH_ID { get; set; }

        public long? HDT_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG_TRINH_DAO_TAO_CHI_TIET> CHUONG_TRINH_DAO_TAO_CHI_TIET { get; set; }

        public virtual NIEN_KHOA NIEN_KHOA { get; set; }

        public virtual NIEN_KHOA NIEN_KHOA1 { get; set; }

        public virtual DM_HE_DAO_TAO DM_HE_DAO_TAO { get; set; }

        public virtual DM_NGANH DM_NGANH { get; set; }
    }
}
