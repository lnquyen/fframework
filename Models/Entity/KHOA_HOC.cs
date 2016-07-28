namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHOA_HOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOA_HOC()
        {
            KHOA_HOC_NIEN_KHOA = new HashSet<KHOA_HOC_NIEN_KHOA>();
            LOP_CHUYEN_NGANH = new HashSet<LOP_CHUYEN_NGANH>();
        }

        [Key]
        public long KH_ID { get; set; }

        [StringLength(50)]
        public string KH_TEN { get; set; }

        [StringLength(255)]
        public string KH_GHI_CHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOA_HOC_NIEN_KHOA> KHOA_HOC_NIEN_KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_CHUYEN_NGANH> LOP_CHUYEN_NGANH { get; set; }
    }
}
