namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_CHUC_DANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_CHUC_DANH()
        {
            DM_GIO_CHUAN_CHUC_DANH = new HashSet<DM_GIO_CHUAN_CHUC_DANH>();
            GV_CHUC_DANH = new HashSet<GV_CHUC_DANH>();
        }

        [Key]
        public long CD_ID { get; set; }

        [StringLength(20)]
        public string CD_MA { get; set; }

        [StringLength(255)]
        public string CD_TEN { get; set; }

        [StringLength(255)]
        public string CD_GHI_CHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_GIO_CHUAN_CHUC_DANH> DM_GIO_CHUAN_CHUC_DANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GV_CHUC_DANH> GV_CHUC_DANH { get; set; }
    }
}
