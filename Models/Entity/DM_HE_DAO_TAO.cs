namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_HE_DAO_TAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_HE_DAO_TAO()
        {
            CHUONG_TRINH_DAO_TAO = new HashSet<CHUONG_TRINH_DAO_TAO>();
            DM_MON_HOC = new HashSet<DM_MON_HOC>();
        }

        [Key]
        public long HDT_ID { get; set; }

        [StringLength(20)]
        public string HDT_MA { get; set; }

        [StringLength(50)]
        public string HDT_TEN { get; set; }

        [StringLength(255)]
        public string HDT_GHI_CHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG_TRINH_DAO_TAO> CHUONG_TRINH_DAO_TAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_MON_HOC> DM_MON_HOC { get; set; }
    }
}
