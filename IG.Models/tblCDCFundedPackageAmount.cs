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
    
    public partial class tblCDCFundedPackageAmount
    {
        public tblCDCFundedPackageAmount()
        {
            this.QuotationIncomeSources = new HashSet<QuotationIncomeSource>();
        }
    
        public System.Guid fldCDCFundedPackageAmountId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public bool fldActive { get; set; }
        public decimal fldDailyRate { get; set; }
        public decimal fldLeaveRate { get; set; }
        public bool fldAutoApprove { get; set; }
        public System.Guid fldFundedPackageId { get; set; }
        public System.Guid fldSupplementAndSubsidyId { get; set; }
    
        public virtual ICollection<QuotationIncomeSource> QuotationIncomeSources { get; set; }
    }
}
