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
    
    public partial class tblInternalCompliance
    {
        public System.Guid fldInternalCompliance { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public Nullable<System.Guid> fldComplianceModule { get; set; }
        public Nullable<System.DateTime> fldDateCompleted { get; set; }
        public Nullable<System.Guid> fldVersion { get; set; }
        public Nullable<System.Guid> fldTrainedBy { get; set; }
        public Nullable<System.DateTime> fldReviewDate { get; set; }
        public Nullable<System.DateTime> fldReminderDate { get; set; }
        public bool fldArchived { get; set; }
    }
}
