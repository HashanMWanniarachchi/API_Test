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
    
    public partial class tblRoster2HomecareTracking
    {
        public System.Guid fldID { get; set; }
        public System.Guid fldRosterShiftId { get; set; }
        public Nullable<System.Guid> fldRosterRuleId { get; set; }
        public Nullable<System.DateTime> fldShiftDate { get; set; }
        public Nullable<System.DateTime> fldOldShiftDate { get; set; }
        public Nullable<System.Guid> fldCarerId { get; set; }
        public Nullable<System.Guid> fldOldCarerId { get; set; }
        public bool fldActive { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public int fldFieldsChanged { get; set; }
    }
}
