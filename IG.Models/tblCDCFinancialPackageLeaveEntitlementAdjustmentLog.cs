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
    
    public partial class tblCDCFinancialPackageLeaveEntitlementAdjustmentLog
    {
        public System.Guid fldId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public bool fldActive { get; set; }
        public System.Guid fldCDCFinancialPackageLeaveEntitlementAdjustmentId { get; set; }
        public System.Guid fldLeaveAdjustmentReasonId { get; set; }
        public string fldComment { get; set; }
        public System.DateTime fldDate { get; set; }
        public short fldOldValue { get; set; }
        public short fldNewValue { get; set; }
    }
}
