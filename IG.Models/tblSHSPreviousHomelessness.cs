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
    
    public partial class tblSHSPreviousHomelessness
    {
        public System.Guid fldSHSPreviousHomelessnessID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldSHSID { get; set; }
        public Nullable<System.Guid> fldPreviousHomelessness { get; set; }
        public Nullable<int> fldType { get; set; }
    }
}
