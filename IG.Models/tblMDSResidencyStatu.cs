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
    
    public partial class tblMDSResidencyStatu
    {
        public System.Guid fldID { get; set; }
        public Nullable<int> fldCode { get; set; }
        public string fldResidencyStatus { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public byte fldEdit { get; set; }
        public Nullable<int> fldAccnaCode { get; set; }
    }
}
