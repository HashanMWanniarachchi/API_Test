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
    
    public partial class tblRoster2Homecare
    {
        public System.Guid fldRosterShiftId { get; set; }
        public Nullable<System.Guid> fldRosterRuleId { get; set; }
        public System.DateTime fldStartTime { get; set; }
        public System.DateTime fldEndTime { get; set; }
        public Nullable<System.Guid> fldClientId { get; set; }
        public Nullable<System.Guid> fldCarerId { get; set; }
        public System.Guid fldFundingId { get; set; }
        public bool fldIsApproved { get; set; }
        public bool fldIsManuallyEdited { get; set; }
        public bool fldIsMaster { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public bool fldIsFrozen { get; set; }
        public Nullable<System.Guid> fldFrozenReasonId { get; set; }
        public Nullable<System.Guid> fldFrozenUserId { get; set; }
        public Nullable<System.Guid> fldGroupId { get; set; }
        public decimal fldExpenses { get; set; }
        public decimal fldTravelDistance { get; set; }
        public decimal fldTravelDistanceInt { get; set; }
        public short fldTravelTime { get; set; }
        public int fldFlag { get; set; }
        public bool fldIsClashing { get; set; }
        public string fldAuditText { get; set; }
        public int fldIsRejected { get; set; }
        public Nullable<System.DateTime> fldUpdatedFrom { get; set; }
        public bool fldIgnorePayMinimum { get; set; }
        public bool fldCancelled { get; set; }
        public Nullable<int> fldMealBreak { get; set; }
        public Nullable<int> fldMeals { get; set; }
        public bool fldPaySupplier { get; set; }
        public Nullable<System.Guid> fldHomeMaintenanceId { get; set; }
        public Nullable<System.Guid> fldLinkedShiftId { get; set; }
        public Nullable<System.Guid> fldRegionId { get; set; }
        public int fldApprovalType { get; set; }
        public Nullable<System.DateTime> fldOriginalShiftDate { get; set; }
        public Nullable<decimal> fldExpensesInt { get; set; }
        public Nullable<System.DateTime> fldWorkedStartTime { get; set; }
        public Nullable<System.DateTime> fldWorkedEndTime { get; set; }
        public Nullable<System.DateTime> fldRosteredStartTime { get; set; }
        public Nullable<System.DateTime> fldRosteredEndTime { get; set; }
        public Nullable<System.Guid> fldActivityID { get; set; }
        public Nullable<System.Guid> fldFacilityID { get; set; }
        public bool fldSubmitted { get; set; }
        public int fldImportStatus { get; set; }
        public string fldOrderNumber { get; set; }
        public Nullable<decimal> fldTotalCharge { get; set; }
        public bool fldExcludeTravel { get; set; }
        public bool fldExcludeTravelManualUpdate { get; set; }
        public Nullable<System.Guid> fldExcludeTravelReason { get; set; }
        public bool fldCarerEdit { get; set; }
        public Nullable<System.Guid> fldAttendeeID { get; set; }
        public Nullable<System.Guid> fldUserDef1 { get; set; }
        public Nullable<System.Guid> fldUserDef2 { get; set; }
        public Nullable<System.Guid> fldUserDef3 { get; set; }
        public Nullable<System.Guid> fldActivityTypeID { get; set; }
        public Nullable<System.Guid> fldCancellationChargeReasonId { get; set; }
        public Nullable<System.Guid> fldPaybandID { get; set; }
        public bool fldIsRecall { get; set; }
        public decimal fldRateofPay { get; set; }
        public bool fldManualKilometreOverride { get; set; }
        public bool fldManualTravelTimeOverride { get; set; }
        public bool fldSubmittedViaCLM { get; set; }
        public bool fldExcludeExpenses { get; set; }
        public Nullable<decimal> fldOverrideCharge { get; set; }
        public bool fldMentalHealthSpecificGroup { get; set; }
        public Nullable<decimal> fldTotalCost { get; set; }
        public Nullable<decimal> fldForecastCost { get; set; }
        public Nullable<System.DateTime> fldDateApproved { get; set; }
        public Nullable<System.Guid> fldShiftStartGeographicCoordinateId { get; set; }
        public Nullable<System.Guid> fldShiftEndGeographicCoordinateId { get; set; }
        public string fldScanReferenceUrl { get; set; }
        public bool fldNoCharge { get; set; }
        public Nullable<System.Guid> fldClientFundingSource { get; set; }
        public bool fldIsFreeService { get; set; }
        public Nullable<System.Guid> fldProfessionalServiceAllowance { get; set; }
        public Nullable<System.Guid> fldRosterRatio { get; set; }
        public Nullable<short> fldOriginalTravelTime { get; set; }
        public Nullable<decimal> fldOriginalTravelDistance { get; set; }
        public Nullable<decimal> fldOriginalTravelDistanceInt { get; set; }
    }
}