//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IG.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblACDCIndirect
    {
        public System.Guid fldId { get; set; }
        public System.Guid fldACDCOutletID { get; set; }
        public Nullable<System.Guid> fldYearID { get; set; }
        public decimal fldIndirectPaidRefWeek { get; set; }
        public decimal fldIndirectUnpaidRefWeek { get; set; }
        public decimal fldIndirectPaidTypWeek { get; set; }
        public decimal fldIndirectUnpaidTypWeek { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public Nullable<bool> fldActive { get; set; }
    }
}