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
    
    public partial class tblTimesheet
    {
        public System.Guid fldCarerID { get; set; }
        public Nullable<System.DateTime> fldShiftDate { get; set; }
        public Nullable<System.Guid> fldPayrate { get; set; }
        public Nullable<decimal> fldHours { get; set; }
        public Nullable<int> fldKilometres { get; set; }
        public Nullable<decimal> fldExpenses { get; set; }
        public Nullable<decimal> fldOther { get; set; }
        public Nullable<System.DateTime> fldPayDate { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserID { get; set; }
        public byte fldActive { get; set; }
        public System.Guid fldTimesheetID { get; set; }
        public Nullable<System.Guid> fldRateTypeID { get; set; }
        public Nullable<System.Guid> fldRosterShiftID { get; set; }
        public Nullable<bool> fldIsTravelTime { get; set; }
        public bool fldIsRestBreak { get; set; }
        public Nullable<System.DateTime> fldExportDate { get; set; }
        public Nullable<System.Guid> fldExportId { get; set; }
        public bool fldIsRosteredTravel { get; set; }
        public Nullable<System.Guid> fldOriginalPayrate { get; set; }
        public int fldUniqueNumber { get; set; }
        public Nullable<System.DateTime> fldSplitDate { get; set; }
        public Nullable<System.DateTime> fldStartTime { get; set; }
        public Nullable<System.DateTime> fldEndTime { get; set; }
        public bool fldManualEntry { get; set; }
        public Nullable<System.Guid> fldAwardRuleId { get; set; }
        public bool fldReversal { get; set; }
        public Nullable<System.Guid> fldMealBreakId { get; set; }
        public string fldAuditText { get; set; }
    }
}