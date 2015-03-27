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
    
    public partial class tblAwardTravel
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldAwardID { get; set; }
        public bool fldSplitShifts { get; set; }
        public Nullable<int> fldSplitShiftPriorGap { get; set; }
        public Nullable<int> fldSplitShiftPostGap { get; set; }
        public Nullable<decimal> fldSplitShiftUnits { get; set; }
        public Nullable<System.Guid> fldSplitShiftRateType { get; set; }
        public bool fldDistanceAllowance { get; set; }
        public Nullable<int> fldDistancePriorGap { get; set; }
        public Nullable<int> fldDistancePostGap { get; set; }
        public bool fldDistanceFromHome { get; set; }
        public bool fldDistanceToHome { get; set; }
        public Nullable<int> fldDistanceMinKilometres { get; set; }
        public Nullable<int> fldDistanceMaximum { get; set; }
        public Nullable<System.Guid> fldDistanceRateType { get; set; }
        public bool fldTimeAllowance { get; set; }
        public Nullable<int> fldTimePriorGap { get; set; }
        public Nullable<int> fldTimePostGap { get; set; }
        public bool fldTimeFromHome { get; set; }
        public bool fldTimeToHome { get; set; }
        public Nullable<int> fldTimeMinTime { get; set; }
        public Nullable<decimal> fldTimeMaximum { get; set; }
        public bool fldTimePayPerKilometre { get; set; }
        public Nullable<System.Guid> fldTimeRateType { get; set; }
        public bool fldFlatRateAllowance { get; set; }
        public Nullable<int> fldFlatRatePriorGap { get; set; }
        public Nullable<int> fldFlatRatePostGap { get; set; }
        public bool fldFlatRateFromHome { get; set; }
        public bool fldFlatRateToHome { get; set; }
        public bool fldFlatRateOnly { get; set; }
        public Nullable<decimal> fldFlatRateUnits { get; set; }
        public Nullable<System.Guid> fldFlatRateRateType { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldSplitShiftPayrate { get; set; }
        public Nullable<System.Guid> fldSplitShiftAllowanceType { get; set; }
        public Nullable<System.Guid> fldDistancePayrate { get; set; }
        public Nullable<System.Guid> fldDistanceAllowanceType { get; set; }
        public Nullable<System.Guid> fldDistanceAllowanceTypeToHome { get; set; }
        public Nullable<System.Guid> fldTimePayrate { get; set; }
        public Nullable<System.Guid> fldTimeAllowanceType { get; set; }
        public Nullable<System.Guid> fldTimeAllowanceTypeToHome { get; set; }
        public Nullable<System.Guid> fldFlatRatePayrate { get; set; }
        public Nullable<System.Guid> fldFlatRateAllowanceType { get; set; }
        public Nullable<System.Guid> fldFlatRateAllowanceTypeToHome { get; set; }
        public Nullable<decimal> fldLastShiftWithin { get; set; }
        public Nullable<decimal> fldNextShiftWithin { get; set; }
        public Nullable<int> fldDistanceMinimum { get; set; }
        public Nullable<int> fldTimeMinimum { get; set; }
        public bool fldUseAddressDates { get; set; }
        public Nullable<int> fldDistanceFromHomeUpperLimit { get; set; }
        public Nullable<System.Guid> fldDistanceFromHomeAllowanceLower { get; set; }
        public Nullable<System.Guid> fldDistanceFromHomeAllowanceUpper { get; set; }
        public Nullable<int> fldDistanceFromHomeAllowanceBuffer { get; set; }
        public Nullable<int> fldDistanceToHomeUpperLimit { get; set; }
        public Nullable<System.Guid> fldDistanceToHomeAllowanceUpper { get; set; }
        public Nullable<int> fldDistanceToHomeBuffer { get; set; }
        public bool fldDistanceMultipleVisits { get; set; }
        public Nullable<System.Guid> fldDistanceMultipleVisitsAllowance { get; set; }
        public bool fldTimeHomeOnly { get; set; }
        public Nullable<System.Guid> fldTimeFromHomeAllowance { get; set; }
        public bool fldTimeCombineHomeTravel { get; set; }
    }
}