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
    
    public partial class tblAssessment
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public Nullable<System.Guid> fldAssessmentReasonID { get; set; }
        public Nullable<System.Guid> fldAssessmentResultID { get; set; }
        public Nullable<System.Guid> fldAssessmentStatusID { get; set; }
        public Nullable<System.Guid> fldPlanID { get; set; }
        public string fldComments { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldCreatedById { get; set; }
        public Nullable<byte> fldArchived { get; set; }
    }
}
