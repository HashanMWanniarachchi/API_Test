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
    
    public partial class tblFundingPackageRate
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldFundingPackageID { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public Nullable<decimal> fldAmount { get; set; }
        public Nullable<int> fldFrequencyUnits { get; set; }
        public Nullable<System.Guid> fldFrequencyID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public bool fldMaximumApplies { get; set; }
        public Nullable<decimal> fldMaximumAmount { get; set; }
        public Nullable<int> fldMaximumFrequencyUnits { get; set; }
        public Nullable<System.Guid> fldMaximumFrequency { get; set; }
    }
}