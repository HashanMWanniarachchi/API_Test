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
    
    public partial class tblCDCFinancialPackageActualIncomeAllocation
    {
        public System.Guid fldId { get; set; }
        public System.Guid fldCdcFinancialPackageId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public bool fldActive { get; set; }
        public System.DateTime fldStartDate { get; set; }
        public System.DateTime fldEndDate { get; set; }
        public System.Guid fldActualisationId { get; set; }
        public decimal fldTotalAmount { get; set; }
        public System.Guid fldFinancialPackageCategoryId { get; set; }
        public Nullable<System.Guid> fldFundedPackageDefaultIncomeAllocationId { get; set; }
        public Nullable<System.Guid> fldIncomeAllocationOverrideId { get; set; }
        public bool fldIsApproved { get; set; }
        public decimal fldOriginalPercent { get; set; }
        public System.Guid fldCdcBudgetId { get; set; }
        public byte fldIncomeSource { get; set; }
    }
}
