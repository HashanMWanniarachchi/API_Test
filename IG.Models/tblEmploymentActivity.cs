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
    
    public partial class tblEmploymentActivity
    {
        public System.Guid fldEmploymentActivityID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldProfileID { get; set; }
        public int fldActivityID { get; set; }
        public Nullable<System.DateTime> fldActivityDate { get; set; }
        public Nullable<System.DateTime> fldActivityTime { get; set; }
        public Nullable<System.Guid> fldEmploymentActivityTypeID { get; set; }
        public Nullable<System.Guid> fldCaseManagerID { get; set; }
        public Nullable<int> fldTimeSpentHours { get; set; }
        public Nullable<int> fldTimeSpentMinutes { get; set; }
        public Nullable<System.Guid> fldEmploymentAppointmentMediumID { get; set; }
        public bool fldNoShow { get; set; }
        public Nullable<System.Guid> fldEmploymentActivityFocusID { get; set; }
        public bool fldActioned { get; set; }
    }
}
