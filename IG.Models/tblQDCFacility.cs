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
    
    public partial class tblQDCFacility
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldFacilityID { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.DateTime> fldDate { get; set; }
        public string fldType { get; set; }
        public Nullable<int> fldAttendance { get; set; }
        public Nullable<int> fldFemales { get; set; }
    }
}
