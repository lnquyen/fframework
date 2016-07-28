namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MH_TIEN_QUYET
    {
        [Key]
        public long TQ_ID { get; set; }

        public long? MH_ID { get; set; }

        public long? MHTQ_ID { get; set; }

        public virtual DM_MON_HOC DM_MON_HOC { get; set; }

        public virtual DM_MON_HOC DM_MON_HOC1 { get; set; }
    }
}
