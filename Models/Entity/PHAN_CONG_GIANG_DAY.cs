namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHAN_CONG_GIANG_DAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHAN_CONG_GIANG_DAY()
        {
            PHAN_CONG_GIANG_DAY_CHI_TIET = new HashSet<PHAN_CONG_GIANG_DAY_CHI_TIET>();
        }

        [Key]
        public long PCGD_ID { get; set; }

        public long? NK_ID { get; set; }

        public virtual NIEN_KHOA NIEN_KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHAN_CONG_GIANG_DAY_CHI_TIET> PHAN_CONG_GIANG_DAY_CHI_TIET { get; set; }
    }
}
