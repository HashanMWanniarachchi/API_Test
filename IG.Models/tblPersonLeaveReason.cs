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
    
    public partial class tblPersonLeaveReason
    {
        public System.Guid fldID { get; set; }
        public string fldReason { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public byte fldEdit { get; set; }
        public string fldDVABreakInEpisodeCode { get; set; }
        public string fldCode { get; set; }
        public bool fldNoCharges { get; set; }
        public bool fldAcuteCare { get; set; }
        public bool fldNonAcuteCare { get; set; }
        public bool fldPlannedLeave { get; set; }
        public Nullable<int> fldCACPCode { get; set; }
        public Nullable<int> fldEACHCode { get; set; }
        public bool fldDisplayEntitlement { get; set; }
        public string fldDisabilityAgeingInPlaceCode { get; set; }
        public string fldCDCCode { get; set; }
        public bool fldLeaveBreak { get; set; }
        public bool fldPoliceCheckLeave { get; set; }
        public bool fldNoShiftApproval { get; set; }
        public bool fldCDCLeave { get; set; }
        public Nullable<int> fldHCPCode { get; set; }
    }
}
