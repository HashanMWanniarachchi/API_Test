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
    
    public partial class tblCabChargeVoucher
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public Nullable<int> fldVoucherNumber { get; set; }
        public Nullable<System.DateTime> fldIssueDate { get; set; }
        public Nullable<System.Guid> fldFundingId { get; set; }
        public Nullable<System.DateTime> fldDateUsed { get; set; }
        public Nullable<decimal> fldAmount { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldExportId { get; set; }
        public string fldFrom { get; set; }
        public string fldTo { get; set; }
        public Nullable<System.DateTime> fldTime { get; set; }
    }
}