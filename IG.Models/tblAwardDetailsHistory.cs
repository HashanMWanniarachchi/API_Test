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
    
    public partial class tblAwardDetailsHistory
    {
        public Nullable<System.Guid> fldID { get; set; }
        public Nullable<System.Guid> fldAwardSettingsID { get; set; }
        public Nullable<int> fldDayFrom { get; set; }
        public Nullable<int> fldDayTo { get; set; }
        public Nullable<System.DateTime> fldTimeFrom { get; set; }
        public Nullable<System.DateTime> fldTimeTo { get; set; }
        public Nullable<decimal> fldMinimumHours { get; set; }
        public Nullable<decimal> fldMaximumHours { get; set; }
        public Nullable<bool> fldMinimumBonusOnce { get; set; }
        public Nullable<bool> fldUseTotalDailyHours { get; set; }
        public Nullable<System.Guid> fldPayrateAfterMaxHours { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<byte> fldActive { get; set; }
        public Nullable<System.Guid> fldPayrate { get; set; }
        public Nullable<bool> fldUseTotalWeeklyHours { get; set; }
        public Nullable<System.Guid> fldPayrateAfterWeeklyMax { get; set; }
        public Nullable<System.Guid> fldTravelTimePayrate { get; set; }
        public Nullable<decimal> fldWeeklyMaximum { get; set; }
        public Nullable<System.Guid> fldPublicHolidayRateType { get; set; }
        public System.Guid fldHistoryID { get; set; }
        public Nullable<int> fldOrder { get; set; }
        public bool fldNoEndTimeBreak { get; set; }
    }
}
