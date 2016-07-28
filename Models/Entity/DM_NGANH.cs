namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_NGANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_NGANH()
        {
            CHUONG_TRINH_DAO_TAO = new HashSet<CHUONG_TRINH_DAO_TAO>();
            LOP_CHUYEN_NGANH = new HashSet<LOP_CHUYEN_NGANH>();
        }

        [Key]
        public long NGANH_ID { get; set; }

        [StringLength(20)]
        public string NGANH_MA { get; set; }

        [StringLength(255)]
        public string NGANH_TEN { get; set; }

        [StringLength(255)]
        public string NGANH_GHI_CHU { get; set; }

        public long? DV_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG_TRINH_DAO_TAO> CHUONG_TRINH_DAO_TAO { get; set; }

        public virtual DM_DON_VI DM_DON_VI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_CHUYEN_NGANH> LOP_CHUYEN_NGANH { get; set; }
    }
}
