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
    
    public partial class tblINICurrentService
    {
        public string fldContactDetails { get; set; }
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldServiceID { get; set; }
        public Nullable<System.Guid> fldINIID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public string fldAgency { get; set; }
        public string fldDescription { get; set; }
        public string fldComments { get; set; }
    }
}
