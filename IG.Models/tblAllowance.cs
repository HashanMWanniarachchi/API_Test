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
    
    public partial class tblAllowance
    {
        public System.Guid fldAllowanceID { get; set; }
        public string fldAllowance { get; set; }
        public string fldAllowanceCode { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<byte> fldActive { get; set; }
        public Nullable<byte> fldEdit { get; set; }
        public Nullable<int> fldExportOrder { get; set; }
        public bool fldRosterAllowance { get; set; }
        public string fldExportLineType { get; set; }
        public bool fldMandatoryRate { get; set; }
    }
}
