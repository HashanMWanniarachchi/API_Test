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
    
    public partial class tblFinancialPackageOutgoing
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldFinancialPackageID { get; set; }
        public string fldInvoiceNumber { get; set; }
        public Nullable<System.DateTime> fldInvoiceDate { get; set; }
        public Nullable<System.Guid> fldSupplier { get; set; }
        public string fldDescription { get; set; }
        public Nullable<decimal> fldAmount { get; set; }
        public string fldGLCode { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldExportId { get; set; }
        public bool fldTaxApplies { get; set; }
        public bool fldIsBudget { get; set; }
        public Nullable<decimal> fldHours { get; set; }
        public string fldSupplierName { get; set; }
        public Nullable<System.Guid> fldFundingCategoryId { get; set; }
        public Nullable<System.DateTime> fldDatePaid { get; set; }
        public Nullable<decimal> fldAmountPaid { get; set; }
        public Nullable<System.Guid> fldProgramBudgetId { get; set; }
    }
}
