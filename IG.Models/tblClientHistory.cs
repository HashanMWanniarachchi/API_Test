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
    
    public partial class tblClientHistory
    {
        public System.Guid fldClientIDHistoryID { get; set; }
        public Nullable<System.Guid> fldClientID { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public Nullable<System.Guid> fldStatus { get; set; }
        public Nullable<System.DateTime> fldDateOfLastStatusChange { get; set; }
        public Nullable<System.Guid> fldReasonForStatusChange { get; set; }
        public Nullable<System.Guid> fldCoordinator { get; set; }
        public Nullable<System.Guid> fldCaseManager { get; set; }
        public Nullable<System.Guid> fldDecisionMaker { get; set; }
        public Nullable<System.Guid> fldMedicalPractitioner { get; set; }
        public Nullable<byte> fldCommunicationBox { get; set; }
        public string fldCommunicationText { get; set; }
        public Nullable<byte> fldMedicationBox { get; set; }
        public string fldMedicationText { get; set; }
        public Nullable<byte> fldRiskAssessmentBox { get; set; }
        public Nullable<byte> fldSafetyAuditBox { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<byte> fldActive { get; set; }
        public Nullable<System.DateTime> fldDateOfAccident { get; set; }
        public string fldClientNumber { get; set; }
        public Nullable<int> fldMDSClientStatus { get; set; }
        public Nullable<int> fldMDSAccomAfterCessation { get; set; }
        public Nullable<System.DateTime> fldCarePlanDate { get; set; }
        public Nullable<System.DateTime> fldSafetyBoxDate { get; set; }
        public Nullable<System.DateTime> fldRiskAssessmentDate { get; set; }
        public Nullable<bool> fldHomeOwnership { get; set; }
        public Nullable<bool> fldMasonicAffiliation { get; set; }
        public Nullable<bool> fldFinancialHardship { get; set; }
        public Nullable<bool> fldHousingLinked { get; set; }
        public Nullable<bool> fldGroupTransport { get; set; }
        public string fldFundingID { get; set; }
        public Nullable<System.DateTime> fldDateServiceCommenced { get; set; }
        public Nullable<System.DateTime> fldDateServiceConcluded { get; set; }
        public string fldAvailabilitySearchInformation { get; set; }
        public Nullable<int> fldMDSCCPDependantChildren { get; set; }
        public Nullable<int> fldMDSCCPDisabilityType { get; set; }
        public Nullable<System.DateTime> fldMDSLastUpdate { get; set; }
        public Nullable<System.Guid> fldMDSTransportPurpose { get; set; }
        public Nullable<System.Guid> fldMDSCessationReason { get; set; }
        public Nullable<System.Guid> fldCSTDACessationReason { get; set; }
        public string fldUserDef1 { get; set; }
        public string fldUserDef2 { get; set; }
        public string fldUserDef3 { get; set; }
        public string fldUserDef4 { get; set; }
        public string fldUserDef5 { get; set; }
        public Nullable<int> fldBPayCode { get; set; }
        public Nullable<System.Guid> fldIncomeLevel { get; set; }
        public bool fldUnableToSign { get; set; }
        public Nullable<System.Guid> fldClientSignatureReasonID { get; set; }
        public Nullable<int> fldFacilityCapacity { get; set; }
        public bool fldPersonalAlarm { get; set; }
        public bool fldFirstAidKit { get; set; }
        public string fldFirstAidKitLocation { get; set; }
        public string fldCommunicationMethods { get; set; }
        public Nullable<bool> fldHRSClient { get; set; }
        public Nullable<System.Guid> fldCALDId { get; set; }
        public bool fldPDSSProgram { get; set; }
        public string fldPDSSGroupType { get; set; }
        public bool fldFacilitySubcontractor { get; set; }
        public Nullable<int> fldPriorityAccessHACC { get; set; }
        public Nullable<int> fldPriorityAccessCACPS { get; set; }
        public Nullable<int> fldPriorityAccessNRCP { get; set; }
        public Nullable<System.Guid> fldRateScheduleID { get; set; }
        public Nullable<int> fldEziPayCallerID { get; set; }
        public Nullable<System.Guid> fldStatusChangeReasonSubId { get; set; }
        public Nullable<System.DateTime> fldLastContactDate { get; set; }
        public bool fldPhamsCoordination { get; set; }
        public Nullable<System.DateTime> fldUserDate1 { get; set; }
        public Nullable<System.DateTime> fldUserDate2 { get; set; }
        public Nullable<System.DateTime> fldUserDate3 { get; set; }
        public Nullable<System.DateTime> fldUserDate4 { get; set; }
        public Nullable<System.DateTime> fldUserDate5 { get; set; }
        public Nullable<System.Guid> fldDefaultFundingBody { get; set; }
        public string fldUniqueHealthIdentifier { get; set; }
        public string fldMedicareNumber { get; set; }
        public string fldHealthCareFund { get; set; }
        public string fldHealthCareFundNumber { get; set; }
        public string fldPrimaryTreatment { get; set; }
        public Nullable<System.Guid> fldIntakeConsentID { get; set; }
        public Nullable<System.Guid> fldMediaConsentID { get; set; }
        public Nullable<System.Guid> fldUniqueHealthIdentifierConsentID { get; set; }
        public bool fldCentrelinkPayments { get; set; }
        public Nullable<System.Guid> fldCentrelinkPaymentTypeID { get; set; }
        public Nullable<System.Guid> fldStudentStatusID { get; set; }
        public Nullable<System.Guid> fldCaseFileSiteID { get; set; }
        public string fldCaseFileHeldByWorkerID { get; set; }
        public string fldTRIMOPADNumber { get; set; }
        public bool fldUnregisteredFRSPClient { get; set; }
        public Nullable<System.Guid> fldEnquirySourceId { get; set; }
        public bool fldRosterFacilityActivityMandatory { get; set; }
        public string fldBlueCardNumber { get; set; }
        public Nullable<System.DateTime> fldBlueCardExpiry { get; set; }
        public Nullable<System.DateTime> fldHealthCareFundExpiry { get; set; }
        public bool fldUserDefBoolean1 { get; set; }
        public bool fldUserDefBoolean2 { get; set; }
        public bool fldUserDefBoolean3 { get; set; }
        public bool fldUserDefBoolean4 { get; set; }
        public bool fldUserDefBoolean5 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem1 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem2 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem3 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem4 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem5 { get; set; }
        public Nullable<System.DateTime> fldUserDate6 { get; set; }
        public Nullable<System.DateTime> fldUserDate7 { get; set; }
        public Nullable<System.DateTime> fldUserDate8 { get; set; }
        public Nullable<System.DateTime> fldUserDate9 { get; set; }
        public Nullable<System.DateTime> fldUserDate10 { get; set; }
        public Nullable<System.DateTime> fldUserDate11 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem6 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem7 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem8 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem9 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem10 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem11 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem12 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem13 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem14 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem15 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem16 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem17 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem18 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem19 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem20 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem21 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem22 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem23 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem24 { get; set; }
        public Nullable<System.Guid> fldUserDefListItem25 { get; set; }
        public bool fldUserDefBoolean6 { get; set; }
        public bool fldUserDefBoolean7 { get; set; }
        public bool fldUserDefBoolean8 { get; set; }
        public bool fldUserDefBoolean9 { get; set; }
        public bool fldUserDefBoolean10 { get; set; }
        public bool fldUserDefBoolean11 { get; set; }
        public bool fldUserDefBoolean12 { get; set; }
        public bool fldUserDefBoolean13 { get; set; }
        public bool fldUserDefBoolean14 { get; set; }
        public bool fldUserDefBoolean15 { get; set; }
        public bool fldUserDefBoolean16 { get; set; }
        public bool fldUserDefBoolean17 { get; set; }
        public bool fldUserDefBoolean18 { get; set; }
        public bool fldUserDefBoolean19 { get; set; }
        public bool fldUserDefBoolean20 { get; set; }
        public bool fldUserDefBoolean21 { get; set; }
        public bool fldUserDefBoolean22 { get; set; }
        public bool fldUserDefBoolean23 { get; set; }
        public bool fldUserDefBoolean24 { get; set; }
        public bool fldUserDefBoolean25 { get; set; }
        public Nullable<System.Guid> fldResidentialSettingId { get; set; }
        public int fldGradeAdjustment { get; set; }
        public Nullable<System.DateTime> fldUserDate12 { get; set; }
        public Nullable<System.DateTime> fldUserDate13 { get; set; }
        public Nullable<System.DateTime> fldUserDate14 { get; set; }
        public Nullable<System.DateTime> fldUserDate15 { get; set; }
        public Nullable<System.DateTime> fldUserDate16 { get; set; }
        public Nullable<System.DateTime> fldUserDate17 { get; set; }
        public Nullable<System.DateTime> fldUserDate18 { get; set; }
        public Nullable<System.DateTime> fldUserDate19 { get; set; }
        public Nullable<System.DateTime> fldUserDate20 { get; set; }
        public Nullable<System.DateTime> fldUserDate21 { get; set; }
        public Nullable<System.DateTime> fldUserDate22 { get; set; }
        public Nullable<System.DateTime> fldUserDate23 { get; set; }
        public Nullable<System.DateTime> fldUserDate24 { get; set; }
        public Nullable<System.DateTime> fldUserDate25 { get; set; }
    }
}
