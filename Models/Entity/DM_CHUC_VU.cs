namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_CHUC_VU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_CHUC_VU()
        {
            DM_GIO_CHUAN_CHUC_VU = new HashSet<DM_GIO_CHUAN_CHUC_VU>();
            GV_CHUC_VU = new HashSet<GV_CHUC_VU>();
        }

        [Key]
        public long CV_ID { get; set; }

        [StringLength(20)]
        public string CV_MA { get; set; }

        [StringLength(255)]
        public string CV_TEN { get; set; }

        [StringLength(255)]
        public string CV_GHI_CHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_GIO_CHUAN_CHUC_VU> DM_GIO_CHUAN_CHUC_VU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GV_CHUC_VU> GV_CHUC_VU { get; set; }
    }
}
