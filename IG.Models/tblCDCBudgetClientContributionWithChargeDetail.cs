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
    
    public partial class tblCDCBudgetClientContributionWithChargeDetail
    {
        public System.Guid fldID { get; set; }
        public System.Guid fldCdcBudgetId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public bool fldActive { get; set; }
        public string fldDescription { get; set; }
        public decimal fldDailyAmount { get; set; }
        public Nullable<System.Guid> fldProgramBudgetId { get; set; }
        public Nullable<System.Guid> fldCategoryId { get; set; }
        public Nullable<System.Guid> fldServiceRequiredId { get; set; }
        public Nullable<System.Guid> fldCarerPersonId { get; set; }
        public Nullable<System.Guid> fldRoster2RuleId { get; set; }
        public System.DateTime fldStartTime { get; set; }
        public System.DateTime fldEndTime { get; set; }
        public bool fldAutoApprove { get; set; }
        public Nullable<System.Guid> fldIncomeTestedCareFeeId { get; set; }
    }
}