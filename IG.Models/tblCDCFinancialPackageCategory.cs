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
    
    public partial class tblCDCFinancialPackageCategory
    {
        public tblCDCFinancialPackageCategory()
        {
            this.QuotationOtherCharges = new HashSet<QuotationOtherCharge>();
        }
    
        public System.Guid fldID { get; set; }
        public string fldCategory { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public byte fldEdit { get; set; }
        public bool fldIsAdjustment { get; set; }
        public bool fldIsIncome { get; set; }
        public bool fldIsExpenditure { get; set; }
        public string fldExportCode { get; set; }
        public bool fldIsBudgetedOnly { get; set; }
        public bool fldIsTopUp { get; set; }
        public Nullable<int> fldOrder { get; set; }
        public bool fldIsDefault { get; set; }
        public bool fldHasOpeningBalance { get; set; }
    
        public virtual ICollection<QuotationOtherCharge> QuotationOtherCharges { get; set; }
    }
}