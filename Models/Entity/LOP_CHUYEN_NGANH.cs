namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOP_CHUYEN_NGANH
    {
        [Key]
        public long LOP_ID { get; set; }

        [StringLength(20)]
        public string LOP_MA { get; set; }

        [StringLength(255)]
        public string LOP_TEN { get; set; }

        public int? LOP_SI_SO { get; set; }

        [StringLength(255)]
        public string LOP_GHI_CHU { get; set; }

        public long? KH_ID { get; set; }

        public long? NGANH_ID { get; set; }

        public long? GV_ID { get; set; }

        public virtual DM_NGANH DM_NGANH { get; set; }

        public virtual GIANG_VIEN GIANG_VIEN { get; set; }

        public virtual KHOA_HOC KHOA_HOC { get; set; }
    }
}
