//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyDaoTao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GV_CHUC_VU
    {
        public long GVCV_ID { get; set; }
        public Nullable<long> GV_ID { get; set; }
        public Nullable<long> CV_ID { get; set; }
        public Nullable<System.DateTime> GVCV_NGAY_BAT_DAU { get; set; }
        public Nullable<System.DateTime> GVCV_NGAY_KET_THUC { get; set; }
        public string GVCV_GHI_CHU { get; set; }
    
        public virtual DM_CHUC_VU DM_CHUC_VU { get; set; }
        public virtual GIANG_VIEN GIANG_VIEN { get; set; }
    }
}
