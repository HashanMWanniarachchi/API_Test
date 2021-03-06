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
    
    public partial class tblEmploymentPlan
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.DateTime> fldPlanDate { get; set; }
        public string fldLocation { get; set; }
        public string fldTypeOfWork { get; set; }
        public Nullable<int> fldEnjoysJob { get; set; }
        public string fldTypeOfWorkDesired { get; set; }
        public Nullable<decimal> fldCurrentRateOfPay { get; set; }
        public Nullable<System.Guid> fldCurrentAward { get; set; }
        public Nullable<int> fldWageAcceptable { get; set; }
        public Nullable<int> fldEmploymentBasis { get; set; }
        public Nullable<int> fldWorkHoursAcceptable { get; set; }
        public string fldPayComments { get; set; }
        public string fldWorkAcceptable { get; set; }
        public Nullable<int> fldJobSuitable { get; set; }
        public string fldJobSuitableComments { get; set; }
        public string fldOverallSatisfaction { get; set; }
        public string fldWorkCourses { get; set; }
        public string fldWorkRelationships { get; set; }
        public string fldSocialEvents { get; set; }
        public string fldLunchBreaks { get; set; }
        public string fldWorkerRelationships { get; set; }
        public Nullable<int> fldWorkTransport { get; set; }
        public Nullable<int> fldTransportConvenience { get; set; }
        public Nullable<int> fldCommunityFacilities { get; set; }
        public bool fldFacilityInfo { get; set; }
        public string fldFacilityComments { get; set; }
        public Nullable<int> fldTrainingSatisfaction { get; set; }
        public bool fldSupportSatisfaction { get; set; }
        public bool fldOfficerSatisfaction { get; set; }
        public Nullable<int> fldTreatment { get; set; }
        public string fldSatisfactionComments { get; set; }
        public Nullable<int> fldComplaintKnowledge { get; set; }
        public bool fldOtherServicesRequired { get; set; }
        public string fldOtherServicesComments { get; set; }
        public bool fldAuditAttended { get; set; }
        public bool fldIEPMeeting { get; set; }
        public string fldIEPMeetingDescription { get; set; }
        public Nullable<int> fldServiceStandards { get; set; }
        public bool fldEntryProcedure { get; set; }
        public bool fldExitProcedure { get; set; }
        public bool fldIndividualNeeds { get; set; }
        public bool fldDecisionMaking { get; set; }
        public bool fldPrivacy { get; set; }
        public bool fldValuedStatus { get; set; }
        public bool fldComplaints { get; set; }
        public bool fldServiceManagement { get; set; }
        public bool fldEmploymentConditions { get; set; }
        public bool fldTraining { get; set; }
        public bool fldVocationalTrainers { get; set; }
        public bool fldFreedomFromAbuse { get; set; }
        public bool fldPolicyBooklet { get; set; }
        public Nullable<System.Guid> fldSatisfactionId { get; set; }
        public bool fldTasksSatisfaction { get; set; }
        public string fldTasksComments { get; set; }
        public Nullable<int> fldDaysWorked { get; set; }
        public Nullable<decimal> fldHoursWorked { get; set; }
        public Nullable<decimal> fldHourlyRatePrevious { get; set; }
        public Nullable<decimal> fldWeeklyRatePrevious { get; set; }
        public Nullable<decimal> fldHourlyRateCurrent { get; set; }
        public Nullable<decimal> fldWeeklyRateCurrent { get; set; }
        public Nullable<System.Guid> fldPayChanged { get; set; }
        public string fldCoworkers { get; set; }
        public string fldCoworkerSatisfaction { get; set; }
        public string fldWorkplaceSatisfaction { get; set; }
        public Nullable<int> fldSafetyRules { get; set; }
        public bool fldSafetyComprehension { get; set; }
        public Nullable<int> fldSkillsAttendance { get; set; }
        public Nullable<int> fldSkillsPunctuality { get; set; }
        public Nullable<int> fldSkillsAbility { get; set; }
        public Nullable<int> fldSkillsEquipment { get; set; }
        public Nullable<int> fldSkillsSafetyRules { get; set; }
        public Nullable<int> fldSkillsCoworkers { get; set; }
        public Nullable<int> fldSkillsSocial { get; set; }
        public string fldSkillsAttendanceComments { get; set; }
        public string fldSkillsPunctualityComments { get; set; }
        public string fldSkillsAbilityComments { get; set; }
        public string fldSkillsEquipmentComments { get; set; }
        public string fldSkillsSafetyRulesComments { get; set; }
        public string fldSkillsCoworkersComments { get; set; }
        public string fldSkillsSocialComments { get; set; }
        public string fldTrainingComments { get; set; }
        public Nullable<int> fldSupervisorSupport { get; set; }
        public Nullable<int> fldSupervisorHelp { get; set; }
        public Nullable<int> fldSupervisorAccessible { get; set; }
        public Nullable<int> fldWorkerMeetings { get; set; }
        public bool fldSafety { get; set; }
        public bool fldFireEvacuation { get; set; }
        public bool fldEmployerIssues { get; set; }
        public bool fldWorkerIssues { get; set; }
        public bool fldDisabilityStandards { get; set; }
        public bool fldContribution { get; set; }
        public string fldContributionComments { get; set; }
        public Nullable<int> fldContributeAudit { get; set; }
        public Nullable<int> fldContributeMeeting { get; set; }
        public Nullable<int> fldContributeIEP { get; set; }
        public string fldContributeComments { get; set; }
        public string fldConcerns { get; set; }
        public string fldComplaintComments { get; set; }
        public Nullable<int> fldComplaintAwareness { get; set; }
        public Nullable<int> fldComplaintProcedure { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldTerminationDate { get; set; }
        public Nullable<System.Guid> fldPersonId { get; set; }
        public Nullable<int> fldPlanType { get; set; }
        public string fldComments { get; set; }
        public string fldMeetingTopics { get; set; }
        public Nullable<int> fldSkillsMemory { get; set; }
        public bool fldVocationalSupport { get; set; }
        public Nullable<System.DateTime> fldNextConsultation { get; set; }
        public bool fldHealthCarePlan { get; set; }
        public Nullable<System.DateTime> fldHealthCarePlanDate { get; set; }
        public string fldHealthCarePlanCompletedBy { get; set; }
        public bool fldRiskPlan { get; set; }
        public Nullable<System.DateTime> fldRiskPlanDate { get; set; }
        public bool fldRiskDocuments { get; set; }
        public bool fldServiceAgreement { get; set; }
        public Nullable<System.DateTime> fldServiceAgreementDate { get; set; }
        public bool fldServiceAgreementDocuments { get; set; }
        public bool fldFamilyAgreement { get; set; }
        public Nullable<System.DateTime> fldFamilyAgreementDate { get; set; }
        public bool fldFamilyAgreementDocuments { get; set; }
        public bool fldConsent { get; set; }
        public Nullable<System.DateTime> fldConsentDate { get; set; }
        public bool fldConsentDocuments { get; set; }
        public bool fldListening { get; set; }
        public Nullable<System.DateTime> fldListeningDate { get; set; }
        public bool fldListeningDocuments { get; set; }
        public bool fldPreIPWork { get; set; }
        public Nullable<System.DateTime> fldPreIPDate { get; set; }
        public bool fldPreIPDocuments { get; set; }
        public bool fldOnePageProfile { get; set; }
        public Nullable<System.DateTime> fldOnePageDate { get; set; }
        public bool fldOnePageDocuments { get; set; }
        public bool fldAssetRegister { get; set; }
        public Nullable<System.DateTime> fldAssetRegisterDate { get; set; }
        public bool fldFinanceReview { get; set; }
        public Nullable<System.DateTime> fldFinanceReviewDate { get; set; }
        public bool fldFinanceReviewDocuments { get; set; }
        public string fldFinalGoal { get; set; }
        public string fldFinalGoalOutcome { get; set; }
        public bool fldFinalGoalCompleted { get; set; }
        public bool fldFinalGoalNewPlan { get; set; }
        public Nullable<int> fldRespected { get; set; }
        public Nullable<int> fldSafe { get; set; }
        public Nullable<int> fldLifeControl { get; set; }
        public Nullable<int> fldEmpowered { get; set; }
        public Nullable<int> fldRepeat { get; set; }
        public Nullable<int> fldChoiceMaking { get; set; }
        public string fldWageAcceptableNo { get; set; }
        public string fldWorkHoursAcceptableNo { get; set; }
        public string fldTransportConvenienceNo { get; set; }
        public Nullable<System.Guid> fldLocationID { get; set; }
        public Nullable<System.Guid> fldDepartment { get; set; }
        public Nullable<int> fldIndividualPlanType { get; set; }
        public Nullable<System.DateTime> fldHealthCare1 { get; set; }
        public Nullable<System.DateTime> fldHealthCare2 { get; set; }
        public Nullable<System.DateTime> fldHealthCare3 { get; set; }
        public Nullable<System.DateTime> fldClientRisks1 { get; set; }
        public Nullable<System.DateTime> fldClientRisks2 { get; set; }
        public Nullable<System.DateTime> fldClientRisks3 { get; set; }
        public Nullable<System.Guid> fldProfileId { get; set; }
        public bool fldCurRateOfPayConfirmedAgainstAward { get; set; }
    }
}
