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
    
    public partial class tblSDMFamilyRisk
    {
        public System.Guid fldID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public bool fldActive { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public bool fldIsReassessment { get; set; }
        public Nullable<System.Guid> fldPrimaryCarerId { get; set; }
        public Nullable<System.Guid> fldSecondaryCarerId { get; set; }
        public Nullable<bool> fldHouseholdAllegation { get; set; }
        public Nullable<System.Guid> fldTeamId { get; set; }
        public Nullable<System.Guid> fldWorkerId { get; set; }
        public Nullable<System.DateTime> fldAssessmentDate { get; set; }
        public Nullable<bool> fldFamilyIndigenous { get; set; }
        public Nullable<bool> fldIsRefugee { get; set; }
        public Nullable<int> fldNeglectScore { get; set; }
        public Nullable<int> fldAbuseScore { get; set; }
        public Nullable<int> fldScoredRiskLevel { get; set; }
        public Nullable<bool> fldPolicyOverride1 { get; set; }
        public Nullable<bool> fldPolicyOverride2 { get; set; }
        public Nullable<bool> fldPolicyOverride3 { get; set; }
        public Nullable<bool> fldPolicyOverride4 { get; set; }
        public Nullable<bool> fldDiscretionaryOverride { get; set; }
        public string fldDiscretionaryReason { get; set; }
        public Nullable<int> fldFinalRiskLevel { get; set; }
        public Nullable<System.Guid> fldApprovalManagerID { get; set; }
        public Nullable<System.DateTime> fldApprovalDate { get; set; }
        public Nullable<int> fldReassessmentNumber { get; set; }
        public Nullable<int> fldOverrideRiskLevel { get; set; }
        public Nullable<System.Guid> fldPersonCaseNumberFamilyId { get; set; }
        public Nullable<System.Guid> fldFamilyCultureId { get; set; }
    }
}