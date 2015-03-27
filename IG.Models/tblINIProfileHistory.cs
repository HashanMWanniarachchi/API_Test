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
    
    public partial class tblINIProfileHistory
    {
        public System.Guid fldAlcoholHistoryID { get; set; }
        public Nullable<int> fldAlcohol { get; set; }
        public Nullable<int> fldBodilyPain { get; set; }
        public Nullable<int> fldBreastScreen { get; set; }
        public Nullable<System.DateTime> fldBreastScreenDate { get; set; }
        public string fldComments { get; set; }
        public string fldCommentsAccommodation { get; set; }
        public Nullable<int> fldDecisionMaking { get; set; }
        public Nullable<bool> fldDisabilityCriteria1 { get; set; }
        public Nullable<bool> fldDisabilityCriteria2 { get; set; }
        public Nullable<bool> fldDisabilityCriteria3 { get; set; }
        public Nullable<bool> fldDisabilityCriteria4 { get; set; }
        public Nullable<int> fldDisabilityEligibility { get; set; }
        public Nullable<int> fldFalls { get; set; }
        public string fldFamilyRelationshipsComments { get; set; }
        public string fldHealthComments { get; set; }
        public Nullable<int> fldHealthInterfere { get; set; }
        public Nullable<int> fldHearing { get; set; }
        public Nullable<int> fldK10Score1 { get; set; }
        public Nullable<int> fldK10Score10 { get; set; }
        public Nullable<int> fldK10Score2 { get; set; }
        public Nullable<int> fldK10Score3 { get; set; }
        public Nullable<int> fldK10Score4 { get; set; }
        public Nullable<int> fldK10Score5 { get; set; }
        public Nullable<int> fldK10Score6 { get; set; }
        public Nullable<int> fldK10Score7 { get; set; }
        public Nullable<int> fldK10Score8 { get; set; }
        public Nullable<int> fldK10Score9 { get; set; }
        public Nullable<int> fldK10Total { get; set; }
        public string fldLegalComments { get; set; }
        public string fldLivingArrangementNotes { get; set; }
        public Nullable<int> fldLongDistVision { get; set; }
        public Nullable<int> fldNoOfFalls { get; set; }
        public Nullable<int> fldNoOfStandardDrinks { get; set; }
        public Nullable<bool> fldNutritionalRisk1 { get; set; }
        public Nullable<bool> fldNutritionalRisk10 { get; set; }
        public Nullable<bool> fldNutritionalRisk2 { get; set; }
        public Nullable<bool> fldNutritionalRisk3 { get; set; }
        public Nullable<bool> fldNutritionalRisk4 { get; set; }
        public Nullable<bool> fldNutritionalRisk5 { get; set; }
        public Nullable<bool> fldNutritionalRisk6 { get; set; }
        public Nullable<bool> fldNutritionalRisk7 { get; set; }
        public Nullable<bool> fldNutritionalRisk8 { get; set; }
        public Nullable<bool> fldNutritionalRisk9 { get; set; }
        public Nullable<int> fldOtherLegalOrder { get; set; }
        public string fldOtherLegalOrderNote { get; set; }
        public Nullable<int> fldOverallHealth { get; set; }
        public Nullable<int> fldPapSmear { get; set; }
        public Nullable<System.DateTime> fldPapSmearDate { get; set; }
        public Nullable<int> fldPersonalandSocial { get; set; }
        public string fldPersonalandSocialComments { get; set; }
        public Nullable<int> fldPhysicalActivity { get; set; }
        public Nullable<int> fldPhysicalFitness { get; set; }
        public string fldPhysicalFitnessComments { get; set; }
        public Nullable<System.DateTime> fldQuitSmokingDate { get; set; }
        public Nullable<int> fldReadingVision { get; set; }
        public string fldScoreQ1 { get; set; }
        public string fldScoreQ2 { get; set; }
        public string fldScoreQ3 { get; set; }
        public string fldScoreQ4 { get; set; }
        public string fldScoreQ5 { get; set; }
        public string fldScoreQ6 { get; set; }
        public string fldScoreQ7 { get; set; }
        public string fldScoreQ8 { get; set; }
        public string fldScoreQ9 { get; set; }
        public Nullable<int> fldSmoking { get; set; }
        public Nullable<int> fldStandardDrinks { get; set; }
        public Nullable<int> fldTradeOffs { get; set; }
        public Nullable<System.Guid> fldINIID { get; set; }
        public string fldDecisionMaker { get; set; }
        public string fldFinancialDecisions { get; set; }
        public string fldCarerAvailability { get; set; }
        public Nullable<System.Guid> fldCarerResidency { get; set; }
        public Nullable<System.Guid> fldCarerRelationship { get; set; }
        public string fldMentalHealthAct { get; set; }
        public string fldAnswer1 { get; set; }
        public string fldAnswer2 { get; set; }
        public string fldAnswer3 { get; set; }
        public string fldAnswer4 { get; set; }
        public string fldAnswer5 { get; set; }
        public string fldAnswer6 { get; set; }
        public string fldAnswer7 { get; set; }
        public string fldAnswer8 { get; set; }
        public string fldAnswer9 { get; set; }
        public string fldK10Answer1 { get; set; }
        public string fldK10Answer2 { get; set; }
        public string fldK10Answer3 { get; set; }
        public string fldK10Answer4 { get; set; }
        public string fldK10Answer5 { get; set; }
        public string fldK10Answer6 { get; set; }
        public string fldK10Answer7 { get; set; }
        public string fldK10Answer8 { get; set; }
        public string fldK10Answer9 { get; set; }
        public string fldK10Answer10 { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<byte> fldActive { get; set; }
        public Nullable<System.Guid> fldID { get; set; }
        public string fldCarerNeed { get; set; }
        public Nullable<int> fldCarerSupport { get; set; }
        public Nullable<int> fldCarerAllowance { get; set; }
        public Nullable<int> fldCarerInformation { get; set; }
        public Nullable<int> fldCarerTraining { get; set; }
        public Nullable<bool> fldCarerStress { get; set; }
        public Nullable<bool> fldCarerIllness { get; set; }
        public Nullable<bool> fldCarerHealth { get; set; }
        public Nullable<bool> fldCarerFactors { get; set; }
        public Nullable<bool> fldConsumerNeeds { get; set; }
        public Nullable<bool> fldConsumerFactors { get; set; }
        public string fldCarerSustainable { get; set; }
        public string fldCarerComments { get; set; }
        public string fldEmploymentComments { get; set; }
        public Nullable<bool> fldDomestic { get; set; }
        public Nullable<bool> fldSelfCare { get; set; }
        public Nullable<bool> fldCognition { get; set; }
        public Nullable<bool> fldBehaviour { get; set; }
        public Nullable<bool> fldSelfCareAids { get; set; }
        public Nullable<bool> fldMedicalCareAids { get; set; }
        public Nullable<bool> fldSupportAids { get; set; }
        public Nullable<bool> fldCarModifications { get; set; }
        public Nullable<bool> fldCommunicationAids { get; set; }
        public Nullable<bool> fldOtherGoods { get; set; }
        public Nullable<bool> fldReadingAids { get; set; }
        public string fldOtherGoodsText { get; set; }
        public Nullable<bool> fldOralHealth { get; set; }
        public string fldOralHealthComments { get; set; }
        public Nullable<bool> fldSpeech { get; set; }
        public string fldSpeechComments { get; set; }
        public Nullable<bool> fldFeet { get; set; }
        public string fldFeetComments { get; set; }
        public Nullable<System.DateTime> fldVaccInfluenza { get; set; }
        public Nullable<System.DateTime> fldVaccPneumococcus { get; set; }
        public Nullable<System.DateTime> fldVaccTetanus { get; set; }
        public Nullable<System.DateTime> fldVaccOther { get; set; }
        public Nullable<bool> fldDriving { get; set; }
        public Nullable<bool> fldFitToDrive { get; set; }
        public string fldDrivingComments { get; set; }
        public string fldContinenceLeaking { get; set; }
        public string fldContinenceCoughing { get; set; }
        public string fldContinenceComments { get; set; }
        public Nullable<decimal> fldWeight { get; set; }
        public Nullable<decimal> fldHeight { get; set; }
        public Nullable<decimal> fldBMI { get; set; }
        public Nullable<decimal> fldSystolicBP { get; set; }
        public Nullable<decimal> fldDiastolicBP { get; set; }
        public Nullable<int> fldPulse { get; set; }
        public Nullable<decimal> fldPulseRate { get; set; }
        public Nullable<bool> fldHypotension { get; set; }
        public Nullable<bool> fldInsomnia { get; set; }
        public string fldFriendships { get; set; }
        public string fldInteracting { get; set; }
        public Nullable<int> fldServiceProviderRelationship { get; set; }
        public string fldFamilyComments { get; set; }
        public string fldServiceProviderComments { get; set; }
        public Nullable<bool> fldNutritionalRisk11 { get; set; }
        public string fldLegalDecisions { get; set; }
        public string fldCapableDecisions { get; set; }
        public string fldFinancialSituation { get; set; }
        public string fldCarerPayment { get; set; }
        public string fldCarerThreats { get; set; }
        public string fldReferralLiving { get; set; }
        public string fldNotesDomestic { get; set; }
        public string fldAnswer10 { get; set; }
        public string fldAnswer11 { get; set; }
        public string fldAnswer12 { get; set; }
        public string fldAnswer13 { get; set; }
        public string fldAnswer14 { get; set; }
        public string fldAnswer15 { get; set; }
        public string fldAnswer16 { get; set; }
        public string fldAnswer17 { get; set; }
        public string fldAnswer18 { get; set; }
        public string fldNotesPersonalCare { get; set; }
        public string fldNotesCommunication { get; set; }
        public string fldNotesCognition { get; set; }
        public Nullable<System.DateTime> fldAssessmentDate { get; set; }
        public string fldAssessorName { get; set; }
        public string fldNotesAssessment { get; set; }
        public Nullable<int> fldFallFear { get; set; }
        public string fldReferralHealth { get; set; }
        public Nullable<bool> fldGeneralHealth { get; set; }
        public Nullable<System.DateTime> fldGeneralHealthDate { get; set; }
        public string fldReferralHealthBehaviour { get; set; }
        public string fldReferralPsychosocial { get; set; }
        public string fldCarerEmotional { get; set; }
        public string fldCarerPhysical { get; set; }
        public string fldCarerWellbeing { get; set; }
        public string fldCarerFinancial { get; set; }
        public string fldCarerServices { get; set; }
        public Nullable<bool> fldCaseManager { get; set; }
        public string fldCaseManagerName { get; set; }
        public string fldCarerIssues { get; set; }
        public string fldCarerDiagnosis { get; set; }
        public string fldPrimaryCareNeed { get; set; }
        public string fldTimeSpentCaring { get; set; }
        public string fldCarerEmployment { get; set; }
        public string fldFallComments { get; set; }
        public string fldContinenceAmount { get; set; }
        public string fldContinenceFrequency { get; set; }
        public Nullable<bool> fldCarerMultiple { get; set; }
        public string fldCarerThreatComments { get; set; }
        public bool fldCarerCheck1 { get; set; }
        public bool fldCarerCheck2 { get; set; }
        public bool fldCarerCheck3 { get; set; }
        public bool fldCarerCheck4 { get; set; }
        public bool fldCarerCheck5 { get; set; }
        public bool fldCarerACAS { get; set; }
        public bool fldCarerHACC { get; set; }
        public bool fldCarerDHS { get; set; }
        public bool fldCarerOther { get; set; }
        public string fldCarerCheckOther { get; set; }
        public bool fldACASLevel { get; set; }
        public Nullable<System.DateTime> fldOralHealthDate { get; set; }
        public bool fldGambling { get; set; }
        public Nullable<int> fldChronic { get; set; }
        public bool fldOralHealthProblems { get; set; }
    }
}