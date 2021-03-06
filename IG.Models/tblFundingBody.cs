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
    
    public partial class tblFundingBody
    {
        public System.Guid fldFundingBodyID { get; set; }
        public System.Guid fldAddressID { get; set; }
        public Nullable<System.Guid> fldPayRateID { get; set; }
        public string fldStandardDebtorCode { get; set; }
        public string fldProviderNumber { get; set; }
        public Nullable<byte> fldApplyCoPayments { get; set; }
        public Nullable<byte> fldClaimNumber { get; set; }
        public Nullable<byte> fldUseClientBilling { get; set; }
        public Nullable<byte> fldAvailable { get; set; }
        public string fldCostAccount { get; set; }
        public string fldExportCode { get; set; }
        public Nullable<System.Guid> fldFundingBodyGroupID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldScheduleID { get; set; }
        public string fldFundingApprovalReferenceTerminology { get; set; }
        public bool fldFundingApprovalDefaultAddCoPay { get; set; }
        public bool fldFundingApprovalMDS { get; set; }
        public bool fldDateOfAccidentRequired { get; set; }
        public bool fldSPNumberRequired { get; set; }
        public bool fldEziPayExempt { get; set; }
        public Nullable<System.Guid> fldEziPayExemptionReason { get; set; }
        public Nullable<System.Guid> fldInvoiceFormat { get; set; }
        public string fldCDCCareType { get; set; }
        public string fldProjectCode { get; set; }
        public Nullable<System.Guid> fldCostScheduleID { get; set; }
    
        public virtual tblAddress tblAddress { get; set; }
    }
}
