namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHUONG_TRINH_DAO_TAO_CHI_TIET
    {
        [Key]
        public long DTCT_ID { get; set; }

        public bool? DTCT_BAT_BUOC { get; set; }

        public long? DT_ID { get; set; }

        public long? HK_ID { get; set; }

        public long? MH_ID { get; set; }

        public virtual CHUONG_TRINH_DAO_TAO CHUONG_TRINH_DAO_TAO { get; set; }

        public virtual HOC_KY HOC_KY { get; set; }

        public virtual DM_MON_HOC DM_MON_HOC { get; set; }
    }
}
