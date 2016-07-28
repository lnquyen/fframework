namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GV_GIANG_DAY
    {
        [Key]
        public long GVGD_ID { get; set; }

        [StringLength(255)]
        public string GVGD_GHI_CHU { get; set; }

        public long? PCGDCT_ID { get; set; }

        public long? GV_ID { get; set; }

        public virtual GIANG_VIEN GIANG_VIEN { get; set; }

        public virtual PHAN_CONG_GIANG_DAY_CHI_TIET PHAN_CONG_GIANG_DAY_CHI_TIET { get; set; }
    }
}
