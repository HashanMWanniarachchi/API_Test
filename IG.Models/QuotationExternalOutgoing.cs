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
    
    public partial class QuotationExternalOutgoing
    {
        public System.Guid Id { get; set; }
        public System.Guid QuotationId { get; set; }
        public Nullable<System.Guid> MaterialId { get; set; }
        public string Supplier { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public bool TaxApplies { get; set; }
        public decimal TaxAmount { get; set; }
        public int OnCostAmountType { get; set; }
        public decimal OnCostAmount { get; set; }
        public decimal OnCostAmountTwo { get; set; }
        public bool OnCostTaxApplies { get; set; }
        public decimal OnCostTaxAmount { get; set; }
        public Nullable<System.Guid> SuppliersId { get; set; }
        public decimal OutgoingTotal { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
    
        public virtual Quotation Quotation { get; set; }
        public virtual tblMaterial tblMaterial { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}