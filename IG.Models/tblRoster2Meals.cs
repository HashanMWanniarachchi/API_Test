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
    
    public partial class tblRoster2Meals
    {
        public System.Guid fldRosterShiftId { get; set; }
        public Nullable<System.Guid> fldRosterRuleId { get; set; }
        public System.DateTime fldStartTime { get; set; }
        public System.DateTime fldEndTime { get; set; }
        public System.Guid fldClientId { get; set; }
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
        public System.Guid fldMealTypeId { get; set; }
        public System.Guid fldRoundId { get; set; }
        public System.Guid fldTemperatureId { get; set; }
        public System.Guid fldPackageId { get; set; }
        public int fldDriverType { get; set; }
        public decimal fldExpenses { get; set; }
        public int fldTravelDistance { get; set; }
        public int fldTravelDistanceInt { get; set; }
        public short fldTravelTime { get; set; }
        public int fldFlag { get; set; }
        public string fldAuditText { get; set; }
        public int fldIsRejected { get; set; }
        public Nullable<System.DateTime> fldUpdatedFrom { get; set; }
        public bool fldCancelled { get; set; }
        public Nullable<System.DateTime> fldOriginalShiftDate { get; set; }
        public Nullable<decimal> fldExpensesInt { get; set; }
        public Nullable<System.Guid> fldFacilityID { get; set; }
        public Nullable<decimal> fldTotalCharge { get; set; }
        public Nullable<System.Guid> fldUserDef1 { get; set; }
        public Nullable<System.Guid> fldUserDef2 { get; set; }
        public Nullable<System.Guid> fldUserDef3 { get; set; }
        public bool fldExportedToCC { get; set; }
        public Nullable<System.Guid> fldCancellationChargeReasonId { get; set; }
        public Nullable<System.DateTime> fldDateApproved { get; set; }
        public bool fldNoCharge { get; set; }
        public Nullable<System.Guid> fldClientFundingSource { get; set; }
        public Nullable<short> fldOriginalTravelTime { get; set; }
        public Nullable<decimal> fldOriginalTravelDistance { get; set; }
        public Nullable<decimal> fldOriginalTravelDistanceInt { get; set; }
    }
}
