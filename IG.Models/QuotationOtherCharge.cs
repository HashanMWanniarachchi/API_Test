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
    
    public partial class QuotationOtherCharge
    {
        public System.Guid Id { get; set; }
        public System.Guid QuotationId { get; set; }
        public System.Guid FundingCategoryId { get; set; }
        public int AmountType { get; set; }
        public decimal DailyAmount { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
    
        public virtual Quotation Quotation { get; set; }
        public virtual tblCDCFinancialPackageCategory tblCDCFinancialPackageCategory { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}