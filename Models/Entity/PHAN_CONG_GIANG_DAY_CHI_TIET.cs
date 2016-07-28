namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHAN_CONG_GIANG_DAY_CHI_TIET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHAN_CONG_GIANG_DAY_CHI_TIET()
        {
            GV_GIANG_DAY = new HashSet<GV_GIANG_DAY>();
        }

        [Key]
        public long PCGDCT_ID { get; set; }

        public long? PCGD_ID { get; set; }

        public long? LHP_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GV_GIANG_DAY> GV_GIANG_DAY { get; set; }

        public virtual LOP_HOC_PHAN LOP_HOC_PHAN { get; set; }

        public virtual PHAN_CONG_GIANG_DAY PHAN_CONG_GIANG_DAY { get; set; }
    }
}
