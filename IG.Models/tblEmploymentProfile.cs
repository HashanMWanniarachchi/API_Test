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
    
    public partial class tblEmploymentProfile
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldAccessingThrough { get; set; }
        public Nullable<System.DateTime> fldAcceptanceDate { get; set; }
        public string fldCRNNumber { get; set; }
        public string fldJobSeekerId { get; set; }
        public string fldFahcsiaId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldPersonId { get; set; }
        public Nullable<System.Guid> fldIndividualId { get; set; }
        public string fldFORMSCaseID { get; set; }
        public Nullable<System.DateTime> fldFORMSStartDate { get; set; }
        public Nullable<System.DateTime> fldInitialDMIDue { get; set; }
        public Nullable<System.DateTime> fldOngoingDMIDue { get; set; }
        public Nullable<System.DateTime> fldDMICompleted { get; set; }
        public string fldEmployeeInterests { get; set; }
        public Nullable<System.DateTime> fldBSWATDue { get; set; }
        public Nullable<decimal> fldCompentency { get; set; }
        public Nullable<decimal> fldProductivity { get; set; }
        public Nullable<decimal> fldWage { get; set; }
        public Nullable<decimal> fldBSWATHrlyRate { get; set; }
        public Nullable<decimal> fldBSWATAnnual { get; set; }
        public Nullable<decimal> fldActualHrlyRate { get; set; }
        public Nullable<decimal> fldHoursPerWeek { get; set; }
        public Nullable<decimal> fldActualAnnualSalary { get; set; }
        public string fldManagedBy { get; set; }
        public Nullable<System.DateTime> fldExitDate { get; set; }
        public Nullable<System.Guid> fldExitReasonID { get; set; }
        public Nullable<System.Guid> fldDESTypeID { get; set; }
        public int fldDirectRegistration { get; set; }
        public Nullable<System.DateTime> fldOngoingSupportStartDate { get; set; }
        public Nullable<System.Guid> fldOngoingSupportLevelID { get; set; }
        public Nullable<System.Guid> fldEmploymentPlanStatusID { get; set; }
        public Nullable<System.DateTime> fldPlanUpdatedDate { get; set; }
        public Nullable<System.Guid> fldBenchmarkID { get; set; }
        public Nullable<System.Guid> fldDEEWRSiteID { get; set; }
        public int fldJobJeopardy { get; set; }
        public Nullable<int> fldTimeWithProvider { get; set; }
        public Nullable<int> fldPeriodOfService { get; set; }
        public Nullable<decimal> fldBenchmarkHours { get; set; }
        public Nullable<System.Guid> fldDepartment { get; set; }
        public int fldUniqueID { get; set; }
        public bool fldServiceSatisfied { get; set; }
        public string fldServiceSatisfiedAdditional { get; set; }
        public bool fldEmployeeConsultantEntry { get; set; }
        public bool fldEmployeeConsultantAdvocate { get; set; }
        public bool fldPrivacyMaintained { get; set; }
        public string fldPrivacyMaintainedAdditional { get; set; }
        public bool fldTreatedFairly { get; set; }
        public string fldTreatedFairlyAdditional { get; set; }
        public bool fldRightTraining { get; set; }
        public string fldRightTrainingAdditional { get; set; }
        public bool fldConsumerReference { get; set; }
        public bool fldDisabilityService { get; set; }
        public string fldDisabilityServiceAdditional { get; set; }
        public bool fldServiceReflect { get; set; }
        public string fldServiceReflectAdditional { get; set; }
        public bool fldComplaintsProcess { get; set; }
        public bool fldTreatedBadly { get; set; }
        public string fldTreatedBadlyAdditional { get; set; }
        public bool fldComplaint { get; set; }
        public string fldComplaintAdditional { get; set; }
        public bool fldComplaintSatisfied { get; set; }
        public string fldComplaintSatisfiedAdditional { get; set; }
        public bool fldEmployeeConsultantGoals { get; set; }
        public string fldEmployeeConsultantGoalsAdditional { get; set; }
        public bool fldSupportPreEmployment { get; set; }
        public string fldSupportPreEmploymentAdditional { get; set; }
        public bool fldSupportReferral { get; set; }
        public string fldSupportReferralAdditional { get; set; }
        public bool fldTrainingCourses { get; set; }
        public string fldTrainingCoursesAdditional { get; set; }
        public bool fldTransportOption { get; set; }
        public string fldTransportOptionAdditional { get; set; }
        public bool fldSupportSuitableEmployment { get; set; }
        public string fldSupportSuitableEmploymentAdditional { get; set; }
        public bool fldSupportTypeOfWork { get; set; }
        public string fldSupportTypeOfWorkAdditional { get; set; }
        public bool fldEmployeeConsultantWorkRights { get; set; }
        public string fldEmployeeConsultantWorkRightsAdditional { get; set; }
        public bool fldMaintainEmployment { get; set; }
        public string fldMaintainEmploymentAdditional { get; set; }
        public bool fldRecommend { get; set; }
        public string fldRecommendAdditional { get; set; }
        public bool fldServiceImprove { get; set; }
        public string fldServiceImproveAdditional { get; set; }
        public string fldOverallClientSatisfaction { get; set; }
        public Nullable<System.Guid> fldParticipationRequirementID { get; set; }
        public Nullable<System.Guid> fldPreferredLocationID { get; set; }
        public Nullable<System.DateTime> fldJobPlacementFeeDate { get; set; }
        public bool fldSocialEventsYN { get; set; }
        public bool fldLunchBreak { get; set; }
        public string fldSuggestedWorkStrategies { get; set; }
        public string fldEmployeeConsultantAdvocateAdditional { get; set; }
        public bool fldGroupForms { get; set; }
        public bool fldInduction { get; set; }
        public Nullable<int> fldSelfCare { get; set; }
        public Nullable<int> fldMobility { get; set; }
        public Nullable<int> fldCommunication { get; set; }
        public Nullable<int> fldInteractions { get; set; }
        public Nullable<int> fldLearning { get; set; }
        public Nullable<int> fldEducation { get; set; }
        public Nullable<int> fldEconomicLife { get; set; }
        public Nullable<int> fldDomesticLife { get; set; }
        public Nullable<int> fldSupportWorking { get; set; }
        public Nullable<int> fldPlacementSequence { get; set; }
        public Nullable<System.DateTime> fldJobPlacementFeeDate2 { get; set; }
        public Nullable<System.DateTime> fldJobPlacementFeeDate4 { get; set; }
        public Nullable<System.DateTime> fldJobPlacementFeeDate3 { get; set; }
        public Nullable<System.Guid> fldManagedByCarerId { get; set; }
        public Nullable<System.DateTime> fldTransitionToRetirementCommencementDate { get; set; }
        public Nullable<System.Guid> fldTransitionOfficer { get; set; }
        public bool fldTransitionPriorityLow { get; set; }
        public bool fldTransitionPriorityMedium { get; set; }
        public bool fldTransitionPriorityHigh { get; set; }
        public bool fldTransitionPriorityUrgent { get; set; }
        public Nullable<System.Guid> fldTransitionReason { get; set; }
        public Nullable<System.Guid> fldTransitionRequirement { get; set; }
        public Nullable<System.DateTime> fldBSWATAssessmentDate { get; set; }
        public Nullable<System.Guid> fldBSWATAssessedWageLevel { get; set; }
        public Nullable<decimal> fldBSWATRecommendedWage { get; set; }
        public bool fldBSWATFOFMSUpdated { get; set; }
        public Nullable<System.Guid> fldBSWATAssessedBy { get; set; }
        public Nullable<System.Guid> fldBSWATAuthorisedBy { get; set; }
        public Nullable<System.DateTime> fldBSWATDateAuthorised { get; set; }
    }
}
