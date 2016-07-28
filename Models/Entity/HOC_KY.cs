namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOC_KY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOC_KY()
        {
            CHUONG_TRINH_DAO_TAO_CHI_TIET = new HashSet<CHUONG_TRINH_DAO_TAO_CHI_TIET>();
        }

        [Key]
        public long HK_ID { get; set; }

        public int? HK_STT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG_TRINH_DAO_TAO_CHI_TIET> CHUONG_TRINH_DAO_TAO_CHI_TIET { get; set; }
    }
}
