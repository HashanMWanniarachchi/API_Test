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
    
    public partial class tblContractTerm
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldContractID { get; set; }
        public Nullable<System.Guid> fldTermTypeID { get; set; }
        public string fldDescription { get; set; }
        public byte[] fldDocument { get; set; }
        public string fldFileName { get; set; }
        public string fldMime { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
    }
}
