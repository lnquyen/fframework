namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GV_DON_VI
    {
        [Key]
        public long GVDV_ID { get; set; }

        public long? GV_ID { get; set; }

        public long? DV_ID { get; set; }

        public DateTime? GVDV_NGAY_BAT_DAU { get; set; }

        public DateTime? GVDV_NGAY_KET_THUC { get; set; }

        [StringLength(255)]
        public string GVDV_GHI_CHU { get; set; }

        public virtual DM_DON_VI DM_DON_VI { get; set; }

        public virtual GIANG_VIEN GIANG_VIEN { get; set; }
    }
}
