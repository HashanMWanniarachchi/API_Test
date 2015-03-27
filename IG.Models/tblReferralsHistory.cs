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
    
    public partial class tblReferralsHistory
    {
        public System.Guid fldReferralIDHistoryID { get; set; }
        public Nullable<System.Guid> fldReferralID { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public Nullable<System.DateTime> fldReferralDate { get; set; }
        public Nullable<System.Guid> fldPriorityID { get; set; }
        public Nullable<System.Guid> fldReferralTypeID { get; set; }
        public Nullable<System.Guid> fldReferredBy { get; set; }
        public string fldComments { get; set; }
        public Nullable<System.Guid> fldAssessedBy { get; set; }
        public Nullable<System.DateTime> fldAssessmentDate { get; set; }
        public Nullable<System.DateTime> fldReviewDate { get; set; }
        public Nullable<System.Guid> fldOutcomeID { get; set; }
        public Nullable<System.Guid> fldOutcomeReasonID { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<byte> fldActive { get; set; }
        public Nullable<int> fldMDSReferralSource { get; set; }
        public string fldReferredByPosition { get; set; }
        public Nullable<System.Guid> fldReferredByOrganisation { get; set; }
        public Nullable<System.DateTime> fldEnquiryDate { get; set; }
        public Nullable<System.Guid> fldReferredToOrganisation { get; set; }
        public Nullable<System.Guid> fldReferredToSite { get; set; }
        public Nullable<System.DateTime> fldReferredToDate { get; set; }
        public string fldReferredByText { get; set; }
        public Nullable<int> fldProgram { get; set; }
        public Nullable<int> fldPriorityScore { get; set; }
        public Nullable<bool> fldProgramCACPS { get; set; }
        public Nullable<bool> fldProgramHACC { get; set; }
        public Nullable<bool> fldProgramNRCP { get; set; }
        public Nullable<System.Guid> fldMDSReferralSourceID { get; set; }
        public Nullable<int> fldPriorityScoreHACC { get; set; }
        public Nullable<int> fldPriorityScoreNRCP { get; set; }
        public Nullable<bool> fldNoAssessment { get; set; }
        public Nullable<System.DateTime> fldInitialContactDate { get; set; }
        public Nullable<bool> fldInterpreterRequired { get; set; }
        public Nullable<System.Guid> fldLanguage { get; set; }
        public Nullable<System.Guid> fldCreatedBy { get; set; }
        public string fldReferredByPhone { get; set; }
        public Nullable<System.Guid> fldReferredByRelationship { get; set; }
        public Nullable<System.DateTime> fldReferralPackSent { get; set; }
        public Nullable<System.Guid> fldMedicalCondition { get; set; }
        public Nullable<System.Guid> fldDiagnosedBy { get; set; }
        public Nullable<System.Guid> fldEnquiryID { get; set; }
        public Nullable<System.DateTime> fldServiceCommenced { get; set; }
        public Nullable<System.Guid> fldReferralMannerOfContactId { get; set; }
        public Nullable<System.Guid> fldCoordinatorID { get; set; }
        public Nullable<System.Guid> fldDecisionMakerID { get; set; }
        public Nullable<System.Guid> fldCaseManagerID { get; set; }
        public string fldReferralNumber { get; set; }
        public Nullable<System.Guid> fldUserDefinedListItem1ID { get; set; }
        public Nullable<System.Guid> fldUserDefinedListItem2ID { get; set; }
        public Nullable<System.Guid> fldUserDefinedListItem3ID { get; set; }
    }
}
