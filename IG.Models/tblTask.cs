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
    
    public partial class tblTask
    {
        public System.Guid fldID { get; set; }
        public string fldTask { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public byte fldEdit { get; set; }
        public string fldTooltip { get; set; }
        public int fldHasiSupportType { get; set; }
        public Nullable<System.Guid> fldHasiSupportTypeId { get; set; }
        public Nullable<int> fldSHSCode { get; set; }
        public string fldFACESCode { get; set; }
        public Nullable<System.Guid> fldRRSPServiceTaskID { get; set; }
        public Nullable<System.Guid> fldMHCSSServiceTask { get; set; }
    }
}
