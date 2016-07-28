namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHOA_HOC_NIEN_KHOA
    {
        [Key]
        public long KHNK_ID { get; set; }

        public long? KH_ID { get; set; }

        public long? NK_ID { get; set; }

        public virtual KHOA_HOC KHOA_HOC { get; set; }

        public virtual NIEN_KHOA NIEN_KHOA { get; set; }
    }
}
