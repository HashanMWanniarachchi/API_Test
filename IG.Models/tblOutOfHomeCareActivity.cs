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
    
    public partial class tblOutOfHomeCareActivity
    {
        public System.Guid fldActivityId { get; set; }
        public System.Guid fldOutOfHomeCareId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.DateTime> fldActivityStartDate { get; set; }
        public Nullable<System.DateTime> fldActivityEndDate { get; set; }
        public Nullable<System.Guid> fldActivityType { get; set; }
        public string fldActivityOtherType { get; set; }
        public string fldActivityNote { get; set; }
    }
}