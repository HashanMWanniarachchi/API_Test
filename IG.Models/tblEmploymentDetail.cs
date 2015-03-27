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
    
    public partial class tblEmploymentDetail
    {
        public System.Guid fldID { get; set; }
        public string fldCompanyName { get; set; }
        public string fldStreetAddress { get; set; }
        public Nullable<System.Guid> fldSuburb { get; set; }
        public string fldTrainer { get; set; }
        public string fldSupervisorName { get; set; }
        public string fldSupervisorPosition { get; set; }
        public string fldSupervisorPhone { get; set; }
        public string fldSupervisorMobile { get; set; }
        public string fldSupervisorFax { get; set; }
        public string fldSupervisorEmail { get; set; }
        public string fldEmployeePosition { get; set; }
        public Nullable<System.Guid> fldAwardId { get; set; }
        public Nullable<int> fldWorkingDays { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public Nullable<System.Guid> fldTerminationReason { get; set; }
        public Nullable<System.DateTime> fldStartTime { get; set; }
        public Nullable<System.DateTime> fldEndTime { get; set; }
        public Nullable<decimal> fldDaysHours { get; set; }
        public Nullable<decimal> fldTotalHours { get; set; }
        public Nullable<System.Guid> fldEmploymentStatusId { get; set; }
        public Nullable<System.Guid> fldEmploymentService { get; set; }
        public bool fldAwardSupported { get; set; }
        public bool fldAdditionalBenefits { get; set; }
        public string fldAdditionalBenefitsDescription { get; set; }
        public bool fldUniformsEquipment { get; set; }
        public string fldUniformsEquipmentDescription { get; set; }
        public string fldDressCode { get; set; }
        public Nullable<int> fldEntitlements { get; set; }
        public string fldLeaveProcedure { get; set; }
        public string fldOvertimeDetails { get; set; }
        public string fldWageIncreases { get; set; }
        public string fldPayrollContact { get; set; }
        public string fldUnion { get; set; }
        public string fldMembershipStandard { get; set; }
        public string fldUnionRep { get; set; }
        public string fldUnionMembershipInfo { get; set; }
        public string fldInductionProcess { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldPersonId { get; set; }
        public Nullable<decimal> fldHourlyRate { get; set; }
        public Nullable<decimal> fldWeeklyRate { get; set; }
        public Nullable<System.Guid> fldProfileId { get; set; }
        public Nullable<decimal> fldSWSRate { get; set; }
        public Nullable<System.DateTime> fldSWSReviewDate { get; set; }
        public Nullable<System.DateTime> fldOutcome13Weeks { get; set; }
        public Nullable<System.DateTime> fldOutcome26Weeks { get; set; }
        public Nullable<System.Guid> fldOrganisationId { get; set; }
        public Nullable<System.Guid> fldDepartment { get; set; }
        public string fldAwardText { get; set; }
        public Nullable<System.Guid> fldMarketerId { get; set; }
        public Nullable<System.Guid> fldMarketingSourceId { get; set; }
        public Nullable<System.Guid> fldWageSubsidyPlacementId { get; set; }
        public bool fldWorkplaceModification { get; set; }
        public string fldWorkplaceModificationType { get; set; }
    }
}