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
    
    public partial class tblReferredTo
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldReferredToOrganisation { get; set; }
        public Nullable<System.Guid> fldReferredToSite { get; set; }
        public Nullable<System.DateTime> fldReferredToDate { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldReferralID { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldMDSReferralTarget { get; set; }
        public Nullable<System.Guid> fldFollowUpId { get; set; }
        public Nullable<System.Guid> fldReferredToOutcomeID { get; set; }
        public Nullable<System.DateTime> fldReferredToOutcomeDate { get; set; }
        public int fldNumberOfPeople { get; set; }
    }
}
