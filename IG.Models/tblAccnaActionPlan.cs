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
    
    public partial class tblAccnaActionPlan
    {
        public System.Guid fldAccnaActionPlanID { get; set; }
        public Nullable<System.Guid> fldAccnaID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldAssessmentTypeID { get; set; }
        public string fldAssessmentTypeText { get; set; }
        public string fldReferredTo { get; set; }
        public Nullable<int> fldReferralPriority { get; set; }
        public bool fldConsentGiven { get; set; }
        public Nullable<int> fldReferralStatus { get; set; }
        public Nullable<System.Guid> fldReferralNotMade { get; set; }
        public string fldReason { get; set; }
        public bool fldConsent { get; set; }
        public Nullable<int> fldSection { get; set; }
        public Nullable<System.Guid> fldServiceType { get; set; }
    }
}