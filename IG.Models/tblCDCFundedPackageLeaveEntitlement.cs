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
    
    public partial class tblCDCFundedPackageLeaveEntitlement
    {
        public System.Guid fldCDCFundedPackageLeaveEntitlementId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public System.Guid fldLeaveTypeId { get; set; }
        public int fldEntitlement { get; set; }
        public bool fldCountType { get; set; }
        public bool fldCountOvernightLeave { get; set; }
        public System.Guid fldCDCFundedPackageId { get; set; }
        public bool fldActive { get; set; }
    }
}