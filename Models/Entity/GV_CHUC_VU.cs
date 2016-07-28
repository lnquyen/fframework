namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GV_CHUC_VU
    {
        [Key]
        public long GVCV_ID { get; set; }

        public long? GV_ID { get; set; }

        public long? CV_ID { get; set; }

        public DateTime? GVCV_NGAY_BAT_DAU { get; set; }

        public DateTime? GVCV_NGAY_KET_THUC { get; set; }

        [StringLength(255)]
        public string GVCV_GHI_CHU { get; set; }

        public virtual DM_CHUC_VU DM_CHUC_VU { get; set; }

        public virtual GIANG_VIEN GIANG_VIEN { get; set; }
    }
}
