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
    
    public partial class tblOHSIncident
    {
        public System.Guid fldID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public string fldRefNumber { get; set; }
        public Nullable<int> fldPersonDetails { get; set; }
        public Nullable<int> fldIncidentType { get; set; }
        public Nullable<int> fldInjuryIncurred { get; set; }
        public bool fldInjuryIncurredYes1 { get; set; }
        public bool fldInjuryIncurredYes2 { get; set; }
        public Nullable<int> fldEquipmentInvolved { get; set; }
        public bool fldEquipmentInvolvedYes1 { get; set; }
        public bool fldEquipmentInvolvedYes2 { get; set; }
        public Nullable<int> fldMaintenanceRequired { get; set; }
        public bool fldMaintenanceRequiredYes { get; set; }
        public Nullable<System.Guid> fldEmployee { get; set; }
        public Nullable<System.Guid> fldEmployeeContactType { get; set; }
        public Nullable<System.Guid> fldEmployeeAddressType { get; set; }
        public Nullable<System.Guid> fldIndividualTitle { get; set; }
        public Nullable<System.Guid> fldIndividualGender { get; set; }
        public string fldIndividualFirstName { get; set; }
        public string fldIndividualLastName { get; set; }
        public Nullable<System.DateTime> fldIndividualDOB { get; set; }
        public Nullable<System.Guid> fldIndividualContactType { get; set; }
        public string fldIndividualContactDetails { get; set; }
        public Nullable<System.Guid> fldIndividualAddressType { get; set; }
        public string fldIndividualAddress { get; set; }
        public Nullable<System.Guid> fldIndividualSuburb { get; set; }
        public Nullable<System.Guid> fldIndividualClassification { get; set; }
        public Nullable<System.Guid> fldIndividualCoordinator { get; set; }
        public Nullable<System.DateTime> fldIncidentDate { get; set; }
        public Nullable<System.DateTime> fldIncidentTime { get; set; }
        public Nullable<int> fldIncidentWhen { get; set; }
        public Nullable<System.Guid> fldFacility { get; set; }
        public Nullable<int> fldLocation { get; set; }
        public string fldAreaDepartment { get; set; }
        public string fldExactLocation { get; set; }
        public string fldEmployeeReporting { get; set; }
        public string fldEmployeeReportingContact { get; set; }
        public string fldWitness { get; set; }
        public string fldWitnessContact { get; set; }
        public string fldDescribeIncident { get; set; }
        public Nullable<System.DateTime> fldShiftTime { get; set; }
        public Nullable<System.DateTime> fldShiftCessation { get; set; }
        public string fldImmediateAction { get; set; }
        public Nullable<int> fldLocationOnBody { get; set; }
        public Nullable<int> fldPersonAffectedOutcome { get; set; }
        public bool fldWorksafe { get; set; }
        public bool fldRegulatory { get; set; }
        public bool fldDHS { get; set; }
        public bool fldWorksafeNotifiable { get; set; }
        public string fldSupervisor { get; set; }
        public string fldSupervisorContact { get; set; }
        public string fldHealthSafety { get; set; }
        public string fldHealthSafetyContact { get; set; }
        public Nullable<int> fldRiskManagement { get; set; }
        public string fldRiskManagementActions { get; set; }
        public Nullable<int> fldRiskConsequence { get; set; }
        public Nullable<int> fldRiskLikelihood { get; set; }
        public Nullable<int> fldRiskLevel { get; set; }
        public Nullable<int> fldNationalRisk { get; set; }
        public Nullable<int> fldGroupManager { get; set; }
        public string fldEnteredBy { get; set; }
        public Nullable<int> fldCompletedBy { get; set; }
        public Nullable<int> fldPredictedLevelRisk { get; set; }
        public Nullable<System.DateTime> fldSupervisorDate { get; set; }
        public Nullable<System.DateTime> fldHealthSafetyDate { get; set; }
        public Nullable<System.DateTime> fldCompletedByDate { get; set; }
        public Nullable<System.Guid> fldWhoHasBeenNotified { get; set; }
        public Nullable<System.Guid> fldIncidentLocation { get; set; }
        public bool fldRecordOfConversation { get; set; }
        public bool fldCriticalIncident { get; set; }
        public Nullable<System.Guid> fldRiskManagementProcess { get; set; }
        public Nullable<System.Guid> fldOutcomeWhoHasBeenNotified { get; set; }
        public Nullable<System.Guid> fldOutcomeCompletedBy { get; set; }
        public Nullable<System.DateTime> fldOutcomeDate { get; set; }
    }
}
