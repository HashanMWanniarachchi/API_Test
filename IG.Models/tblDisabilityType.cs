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
    
    public partial class tblDisabilityType
    {
        public System.Guid fldDisabilityTypeID { get; set; }
        public string fldDisabilityType { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public byte fldEdit { get; set; }
        public Nullable<int> fldQDCCode { get; set; }
        public bool fldEmergencySummary { get; set; }
        public bool fldIncludeOnHASI { get; set; }
        public bool fldIsMentalIllness { get; set; }
        public Nullable<int> fldPrimDiagnosis { get; set; }
        public Nullable<int> fldAddDiagnosis { get; set; }
        public string fldHASICode { get; set; }
        public string fldDEEWRCode { get; set; }
        public Nullable<int> fldCENACode { get; set; }
        public string fldRRSPCode { get; set; }
        public bool fldIncludeOnRRSP { get; set; }
        public string fldACDCCode { get; set; }
    }
}
