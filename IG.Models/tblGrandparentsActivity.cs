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
    
    public partial class tblGrandparentsActivity
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldMainID { get; set; }
        public Nullable<System.Guid> fldActivity { get; set; }
        public string fldServiceProvider { get; set; }
        public string fldServiceNumber { get; set; }
        public string fldStreetAddress { get; set; }
        public Nullable<System.Guid> fldSuburb { get; set; }
        public bool fldAccompanied { get; set; }
        public Nullable<int> fldDurationDays { get; set; }
        public Nullable<int> fldDurationNights { get; set; }
        public Nullable<int> fldDurationPartDays { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public bool fldTransportRequired { get; set; }
        public string fldDescription { get; set; }
        public string fldReferralComments { get; set; }
        public Nullable<decimal> fldActivityCost { get; set; }
        public Nullable<decimal> fldTravelCost { get; set; }
        public string fldModeOfTransport { get; set; }
        public string fldFrom { get; set; }
        public string fldTo { get; set; }
        public Nullable<decimal> fldMembershipCost { get; set; }
        public Nullable<decimal> fldEquipmentCost { get; set; }
        public Nullable<decimal> fldOtherCost { get; set; }
        public string fldOtherCostText { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
    }
}
