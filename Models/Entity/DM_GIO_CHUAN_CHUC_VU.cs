namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_GIO_CHUAN_CHUC_VU
    {
        [Key]
        public long GCCV_ID { get; set; }

        public long? CV_ID { get; set; }

        public decimal? GCCV_PHAN_TRAM { get; set; }

        public DateTime? GCCV_NGAY_AP_DUNG { get; set; }

        public virtual DM_CHUC_VU DM_CHUC_VU { get; set; }
    }
}
