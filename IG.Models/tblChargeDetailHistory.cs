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
    
    public partial class tblChargeDetailHistory
    {
        public System.Guid fldChargeDetailsHistoryID { get; set; }
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldPersonId { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public Nullable<System.Guid> fldPackageId { get; set; }
        public bool fldOverrideCharges { get; set; }
        public Nullable<decimal> fldAmount { get; set; }
        public Nullable<int> fldFrequencyUnits { get; set; }
        public Nullable<System.Guid> fldFrequencyId { get; set; }
        public Nullable<System.Guid> fldFundingId { get; set; }
        public Nullable<System.Guid> fldCarerId { get; set; }
        public bool fldProRateCharges { get; set; }
        public bool fldMaximumApplies { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public bool fldClientOverride { get; set; }
        public bool fldApplyCopayment { get; set; }
        public Nullable<int> fldCopaymentApplies { get; set; }
        public Nullable<System.Guid> fldCopaymentId { get; set; }
        public Nullable<decimal> fldMaxAmount { get; set; }
        public Nullable<int> fldMaxFrequencyUnits { get; set; }
        public Nullable<System.Guid> fldMaxFrequencyId { get; set; }
        public Nullable<bool> fldMaxClientOverride { get; set; }
    }
}