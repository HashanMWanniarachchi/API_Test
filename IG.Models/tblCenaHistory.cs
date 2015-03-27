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
    
    public partial class tblCenaHistory
    {
        public System.Guid fldCenaHistoryID { get; set; }
        public System.Guid fldCenaID { get; set; }
        public Nullable<System.Guid> fldAccnaID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public bool fldConsent { get; set; }
        public bool fldInitialAssessment { get; set; }
        public bool fldReassessment { get; set; }
        public bool fldCaring6Month { get; set; }
        public Nullable<int> fldCaringPeople { get; set; }
        public string fldCarerStatusComments { get; set; }
        public bool fldCarerRegular { get; set; }
        public bool fldCarerEmployment { get; set; }
        public bool fldCarerWork { get; set; }
        public bool fldCarerOneOff { get; set; }
        public string fldOutcomeComments { get; set; }
        public Nullable<System.DateTime> fldCarerContact { get; set; }
        public bool fldCarerConsent { get; set; }
        public bool fldCarerConsentTools { get; set; }
        public bool fldPensionerConcessionCard { get; set; }
        public Nullable<int> fldNeedsAssessment { get; set; }
        public int fldDementia { get; set; }
        public Nullable<System.Guid> fldChallengingBehaviour { get; set; }
        public Nullable<int> fldLegalIssues { get; set; }
        public Nullable<int> fldAtHome { get; set; }
        public Nullable<int> fldFutureConcerns { get; set; }
        public string fldFutureComments { get; set; }
        public int fldFinancialStrain { get; set; }
        public string fldFinancialEmployment { get; set; }
        public Nullable<int> fldLeaveWork { get; set; }
        public Nullable<int> fldInterfereJob { get; set; }
        public bool fldSupportServices { get; set; }
        public string fldValuableInformation { get; set; }
        public Nullable<int> fldCareTasks { get; set; }
        public string fldCareTasksComments { get; set; }
        public Nullable<int> fldBehaviourManagementHours { get; set; }
        public bool fldTimeTaken { get; set; }
        public bool fldChallenges { get; set; }
        public Nullable<System.Guid> fldChallenge { get; set; }
        public string fldChallengeOther { get; set; }
        public string fldChallengeComments { get; set; }
        public Nullable<int> fldStrain { get; set; }
        public string fldStrainProblems { get; set; }
        public Nullable<int> fldStrainPerson { get; set; }
        public string fldStrainComments { get; set; }
        public Nullable<int> fldZaritTime { get; set; }
        public Nullable<int> fldZaritStressed { get; set; }
        public Nullable<int> fldZaritStrained { get; set; }
        public Nullable<int> fldZaritUncertain { get; set; }
        public bool fldPositiveHelpingCR { get; set; }
        public bool fldPositiveHelpingFamily { get; set; }
        public bool fldPositiveAccomplishment { get; set; }
        public bool fldPositiveCaring { get; set; }
        public bool fldPositiveAppreciated { get; set; }
        public bool fldPositiveOther { get; set; }
        public bool fldPositiveNone { get; set; }
        public bool fldPositiveDontKnow { get; set; }
        public string fldPositiveComments { get; set; }
        public Nullable<int> fldConcerns { get; set; }
        public string fldConcernsComments { get; set; }
        public Nullable<int> fldFutureGoals { get; set; }
        public string fldFutureGoalsComments { get; set; }
        public string fldRiskComments { get; set; }
        public Nullable<int> fldPriorityRatingCarerNeeds { get; set; }
        public Nullable<int> fldPriorityRatingCareRecipientNeeds { get; set; }
        public Nullable<int> fldPriorityRatingSustainability { get; set; }
        public Nullable<System.Guid> fldCarerServiceStatus { get; set; }
        public bool fldServiceAccepted { get; set; }
        public Nullable<System.Guid> fldReasonNotAccepted { get; set; }
        public string fldActionPlanComments { get; set; }
        public bool fldReferralTo { get; set; }
        public string fldCenaNoReferralComments { get; set; }
        public bool fldINHelpLine { get; set; }
        public bool fldINTalk { get; set; }
        public bool fldINCondition { get; set; }
        public bool fldINLegal { get; set; }
        public bool fldINClientCare { get; set; }
        public bool fldINPay { get; set; }
        public bool fldINServices { get; set; }
        public bool fldINNoAdditional { get; set; }
        public bool fldINOther { get; set; }
        public string fldINOtherText { get; set; }
        public int fldAlcoholUse { get; set; }
        public string fldAlcoholComments { get; set; }
        public Nullable<int> fldPositiveCare { get; set; }
        public Nullable<int> fldPositiveTolerant { get; set; }
        public Nullable<int> fldPositiveFamilyGrowth { get; set; }
        public Nullable<int> fldPositiveConfidence { get; set; }
        public Nullable<int> fldPositiveCloser { get; set; }
        public Nullable<int> fldPositiveOverall { get; set; }
        public string fldPositiveCarerComments { get; set; }
        public Nullable<int> fldEvaluationTimeTaken { get; set; }
        public Nullable<int> fldEvaluationContacts { get; set; }
        public Nullable<int> fldEvaluationContactsOther { get; set; }
        public Nullable<int> fldEvaluationConducted { get; set; }
        public Nullable<int> fldEvaluationUse { get; set; }
        public bool fldQuestionOrder { get; set; }
        public bool fldInformationMissed { get; set; }
        public string fldInformationMissedYes { get; set; }
        public string fldInformationMissedWhy { get; set; }
        public bool fldDifficultQuestions { get; set; }
        public string fldDifficultQuestionsComments { get; set; }
        public string fldUsefulQuestions { get; set; }
        public bool fldQuestionsBetterLater { get; set; }
        public string fldQuestionsBetterLaterComments { get; set; }
        public bool fldPriorityRatingAgree { get; set; }
        public string fldScoreConfidence { get; set; }
        public Nullable<int> fldOutcomeConfidence { get; set; }
        public bool fldEmergencyRespite { get; set; }
        public string fldFurtherComments { get; set; }
        public string fldCenaAdditionalInformation { get; set; }
        public string fldCareRecipientComments { get; set; }
        public bool fldCarerPensionerConcessionCard { get; set; }
        public bool fldLiveWithCR { get; set; }
        public bool fldPrimaryCarer { get; set; }
        public Nullable<int> fldNeedLevel { get; set; }
        public string fldStrainWho { get; set; }
        public bool fldRiskCarerEmotional { get; set; }
        public bool fldRiskCarerAcute { get; set; }
        public bool fldRiskCarerSlow { get; set; }
        public bool fldRiskCarerFactors { get; set; }
        public bool fldRiskCRNeeds { get; set; }
        public bool fldRiskCROther { get; set; }
        public string fldFormalServicesComments { get; set; }
        public string fldCarerPreferredLanguage { get; set; }
        public Nullable<System.Guid> fldCarerPension { get; set; }
        public Nullable<System.Guid> fldCarerContactAddress { get; set; }
        public string fldCarerEmploymentStatus { get; set; }
        public Nullable<System.DateTime> fldCaringStartDate { get; set; }
        public string fldBreakdownRisk { get; set; }
    }
}
