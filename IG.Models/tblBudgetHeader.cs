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
    
    public partial class tblBudgetHeader
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldAddressId { get; set; }
        public Nullable<System.Guid> fldServiceId { get; set; }
        public Nullable<System.Guid> fldRateTypeId { get; set; }
        public Nullable<System.DateTime> fldDateFrom { get; set; }
        public Nullable<System.DateTime> fldDateTo { get; set; }
        public string fldComments { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public bool fldCostBudget { get; set; }
        public Nullable<System.Guid> fldEmploymentBasisId { get; set; }
    }
}
