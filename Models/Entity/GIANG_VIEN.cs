namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GIANG_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIANG_VIEN()
        {
            GV_CHUC_DANH = new HashSet<GV_CHUC_DANH>();
            GV_CHUC_VU = new HashSet<GV_CHUC_VU>();
            GV_DON_VI = new HashSet<GV_DON_VI>();
            GV_GIANG_DAY = new HashSet<GV_GIANG_DAY>();
            LOP_CHUYEN_NGANH = new HashSet<LOP_CHUYEN_NGANH>();
        }

        [Key]
        public long GV_ID { get; set; }

        [StringLength(20)]
        public string GV_MA { get; set; }

        [StringLength(255)]
        public string GV_HOTEN { get; set; }

        public bool? GV_GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? GV_NGAYSINH { get; set; }

        public DateTime? GV_NGAY_BAT_DAU { get; set; }

        public DateTime? GV_NGAY_KET_THUC { get; set; }

        [StringLength(255)]
        public string GV_DIACHI { get; set; }

        [StringLength(100)]
        public string GV_EMAIL { get; set; }

        [StringLength(15)]
        public string GV_SDT { get; set; }

        public long? DV_ID { get; set; }

        public virtual DM_DON_VI DM_DON_VI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GV_CHUC_DANH> GV_CHUC_DANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GV_CHUC_VU> GV_CHUC_VU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GV_DON_VI> GV_DON_VI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GV_GIANG_DAY> GV_GIANG_DAY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP_CHUYEN_NGANH> LOP_CHUYEN_NGANH { get; set; }
    }
}
