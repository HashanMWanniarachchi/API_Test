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
    
    public partial class tblCDCFundedPackage
    {
        public System.Guid fldFundedPackageID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public bool fldActive { get; set; }
        public Nullable<System.Guid> fldFundingBodyGroupID { get; set; }
        public System.Guid fldFundedPackageProgramID { get; set; }
        public System.DateTime fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public int fldFundedPlaces { get; set; }
        public int fldNonFundedPlaces { get; set; }
        public bool fldUnlimitedFunded { get; set; }
        public bool fldUnlimitedNonFunded { get; set; }
        public System.Guid fldRecurrenceId { get; set; }
        public bool fldActualiseInAdvance { get; set; }
    }
}
