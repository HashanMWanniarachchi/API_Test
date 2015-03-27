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
    
    public partial class tblFundingApprovalFunding
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldFundingApprovalId { get; set; }
        public Nullable<System.Guid> fldFundingBodyId { get; set; }
        public Nullable<System.Guid> fldServiceId { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public Nullable<decimal> fldMaxHours { get; set; }
        public Nullable<int> fldMaxHoursFrequencyUnits { get; set; }
        public Nullable<System.Guid> fldMaxHoursFrequency { get; set; }
        public Nullable<int> fldMaxKms { get; set; }
        public Nullable<int> fldMaxKmsFrequencyUnits { get; set; }
        public Nullable<System.Guid> fldMaxKmsFrequency { get; set; }
        public string fldReference { get; set; }
        public Nullable<System.Guid> fldBillingAddressId { get; set; }
        public string fldBillingOrganisation { get; set; }
        public string fldBillingContact { get; set; }
        public Nullable<int> fldWeekendService { get; set; }
        public Nullable<int> fldPublicHolidayService { get; set; }
        public Nullable<decimal> fldCopaymentRate { get; set; }
        public Nullable<decimal> fldCopaymentHours { get; set; }
        public Nullable<decimal> fldCopaymentMaxCharge { get; set; }
        public Nullable<int> fldCopaymentMaxChargeFrequencyUnits { get; set; }
        public Nullable<System.Guid> fldCopaymentMaxChargeFrequency { get; set; }
        public bool fldCopaymentAddCharges { get; set; }
        public Nullable<int> fldCopaymentServicePlan { get; set; }
        public Nullable<System.Guid> fldCopaymentBillingAddress { get; set; }
        public byte[] fldDocument { get; set; }
        public string fldFileName { get; set; }
        public string fldMime { get; set; }
        public string fldNotes { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public string fldCopaymentBillingName { get; set; }
        public string fldCopaymentBillingContact { get; set; }
        public Nullable<System.DateTime> fldEffectiveFrom { get; set; }
        public Nullable<System.Guid> fldPriorityId { get; set; }
    }
}
