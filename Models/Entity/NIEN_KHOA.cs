namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NIEN_KHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NIEN_KHOA()
        {
            CHUONG_TRINH_DAO_TAO = new HashSet<CHUONG_TRINH_DAO_TAO>();
            CHUONG_TRINH_DAO_TAO1 = new HashSet<CHUONG_TRINH_DAO_TAO>();
            KHOA_HOC_NIEN_KHOA = new HashSet<KHOA_HOC_NIEN_KHOA>();
            PHAN_CONG_GIANG_DAY = new HashSet<PHAN_CONG_GIANG_DAY>();
        }

        [Key]
        public long NK_ID { get; set; }

        [StringLength(20)]
        public string NK_TEN { get; set; }

        public int? NK_NAM_BAT_DAU { get; set; }

        public int? NK_NAM_KET_THUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG_TRINH_DAO_TAO> CHUONG_TRINH_DAO_TAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUONG_TRINH_DAO_TAO> CHUONG_TRINH_DAO_TAO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOA_HOC_NIEN_KHOA> KHOA_HOC_NIEN_KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHAN_CONG_GIANG_DAY> PHAN_CONG_GIANG_DAY { get; set; }
    }
}
