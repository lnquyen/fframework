namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOP_HOC_PHAN_CHI_TIET
    {
        [Key]
        public long LHPCT_ID { get; set; }

        public int? LHPCT_SI_SO { get; set; }

        public long? LHP_ID { get; set; }

        public virtual LOP_HOC_PHAN LOP_HOC_PHAN { get; set; }
    }
}
