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
    
    public partial class tblCDCBudgetIncomeAllocationOverride
    {
        public System.Guid fldID { get; set; }
        public System.Guid fldCdcBudgetId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public bool fldActive { get; set; }
        public System.Guid fldCdcFinancialPackageCategoryId { get; set; }
        public decimal fldAmount { get; set; }
        public bool fldAllocateByPercentage { get; set; }
        public decimal fldPercent { get; set; }
        public byte fldAmountType { get; set; }
    }
}
