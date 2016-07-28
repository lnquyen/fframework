namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOP_HOC_PHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP_HOC_PHAN()
        {
            LOP_HOC_PHAN_CHI_TIET = new HashSet<LOP_HOC_PHAN_CHI_TIET>();
            PHAN_CONG_GIANG_DAY_CHI_TIET = new HashSet<PHAN_CONG_GIANG_DAY_CHI_TIET>();
        }

        [Key]
        public long LHP_ID { get; set; }

        [StringLength(20)]
        public string LHP_MA { get; set; }

        [StringLength(255)]
        public string LHP_GHI_CHU { get; set; }

        public long? MH_ID { get; set; }

        public virtual DM_MON_HOC DM_MON_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_HOC_PHAN_CHI_TIET> LOP_HOC_PHAN_CHI_TIET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHAN_CONG_GIANG_DAY_CHI_TIET> PHAN_CONG_GIANG_DAY_CHI_TIET { get; set; }
    }
}
