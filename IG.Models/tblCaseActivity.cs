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
    
    public partial class tblCaseActivity
    {
        public System.Guid fldCaseActivityID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldCaseManagementID { get; set; }
        public int fldActivityID { get; set; }
        public Nullable<System.DateTime> fldActivityDate { get; set; }
        public Nullable<System.DateTime> fldActivityTime { get; set; }
        public Nullable<System.Guid> fldCaseActivityTypeID { get; set; }
        public Nullable<System.Guid> fldCaseWorkerID { get; set; }
        public Nullable<int> fldTimeSpentHours { get; set; }
        public Nullable<int> fldTimeSpentMinutes { get; set; }
        public Nullable<System.Guid> fldAppointmentMediumID { get; set; }
        public bool fldNoShow { get; set; }
        public Nullable<System.Guid> fldActivityFocusId { get; set; }
        public bool fldActioned { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
    }
}
