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
    
    public partial class tblRosterCharge
    {
        public Nullable<System.Guid> fldRosterShiftID { get; set; }
        public string fldAccount { get; set; }
        public Nullable<decimal> fldCharge { get; set; }
        public Nullable<System.Guid> fldRateType { get; set; }
        public Nullable<decimal> fldTaxAmount { get; set; }
        public Nullable<decimal> fldTotalAmount { get; set; }
        public Nullable<int> fldInvoiceNumber { get; set; }
        public System.DateTime fldApprovalDate { get; set; }
        public Nullable<decimal> fldUnits { get; set; }
        public Nullable<System.Guid> fldBillingAddressID { get; set; }
        public string fldBillingContactName { get; set; }
        public byte fldCopayment { get; set; }
        public string fldBillingName { get; set; }
        public string fldBillingContact { get; set; }
        public Nullable<System.DateTime> fldInvoiceDate { get; set; }
        public System.Guid fldID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<decimal> fldChargeRate { get; set; }
        public Nullable<System.Guid> fldExportId { get; set; }
        public string fldRateCode { get; set; }
        public string fldDescription { get; set; }
        public bool fldManualCharge { get; set; }
        public bool fldOverrideRate { get; set; }
        public int fldUniqueID { get; set; }
        public bool fldReversal { get; set; }
        public Nullable<System.Guid> fldOutOfHomeCareId { get; set; }
        public Nullable<System.Guid> fldNDISSupportNumberID { get; set; }
        public string fldNDISClaimReferenceNumber { get; set; }
        public Nullable<System.DateTime> fldNDISExportDate { get; set; }
        public Nullable<System.Guid> fldNDISExportId { get; set; }
        public Nullable<System.Guid> fldRatesID { get; set; }
    }
}
