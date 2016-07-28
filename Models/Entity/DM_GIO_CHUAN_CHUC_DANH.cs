namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_GIO_CHUAN_CHUC_DANH
    {
        [Key]
        public long GCCD_ID { get; set; }

        public long? CD_ID { get; set; }

        public decimal? GCCD_SO_GIO { get; set; }

        public DateTime? GCCD_NGAY_AP_DUNG { get; set; }

        public virtual DM_CHUC_DANH DM_CHUC_DANH { get; set; }
    }
}
