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
    
    public partial class tblBIR
    {
        public System.Guid fldBIRID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public int fldBIRNumber { get; set; }
        public Nullable<System.DateTime> fldDateLogged { get; set; }
        public Nullable<System.Guid> fldServiceArea { get; set; }
        public Nullable<System.Guid> fldFeedbackType { get; set; }
        public Nullable<System.Guid> fldRaisedBy { get; set; }
        public Nullable<int> fldServiceProvider { get; set; }
        public string fldServiceProviderOther { get; set; }
        public Nullable<System.Guid> fldIssueRaiser { get; set; }
        public Nullable<System.Guid> fldReceivedBy { get; set; }
        public Nullable<System.Guid> fldReceiver { get; set; }
        public Nullable<System.DateTime> fldDateReceived { get; set; }
        public string fldSummaryContent { get; set; }
        public Nullable<System.Guid> fldIssueType { get; set; }
        public string fldActionTaken { get; set; }
        public Nullable<System.Guid> fldActionTakenBy { get; set; }
        public bool fldActionTakenComplete { get; set; }
        public Nullable<System.Guid> fldVerifiedBy { get; set; }
        public Nullable<System.DateTime> fldNextDueDate { get; set; }
        public Nullable<System.DateTime> fldActionTakenDate { get; set; }
        public bool fldExported { get; set; }
        public bool fldReexport { get; set; }
        public Nullable<System.Guid> fldManager { get; set; }
        public Nullable<System.Guid> fldFollowUp { get; set; }
        public Nullable<System.Guid> fldCreatedBy { get; set; }
    }
}
