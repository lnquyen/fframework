namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GV_CHUC_DANH
    {
        [Key]
        public long GVCD_ID { get; set; }

        public long? GV_ID { get; set; }

        public long? CD_ID { get; set; }

        public DateTime? GVCD_NGAY_BAT_DAU { get; set; }

        public DateTime? GVCD_NGAY_KET_THUC { get; set; }

        [StringLength(255)]
        public string GVCD_GHI_CHU { get; set; }

        public virtual DM_CHUC_DANH DM_CHUC_DANH { get; set; }

        public virtual GIANG_VIEN GIANG_VIEN { get; set; }
    }
}
