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
    
    public partial class tblFinancialPackageFundingSource
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldFinancialPackageId { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public Nullable<decimal> fldFundedAmount { get; set; }
        public Nullable<decimal> fldFundedHours { get; set; }
        public Nullable<System.Guid> fldProgramBudgetID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public string fldDescription { get; set; }
        public Nullable<System.Guid> fldFinancialPackageCategoryId { get; set; }
        public Nullable<System.Guid> fldFinancialPackagePlanId { get; set; }
        public System.Guid fldPlannedIncomeId { get; set; }
    }
}
