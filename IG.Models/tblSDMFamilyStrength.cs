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
    
    public partial class tblSDMFamilyStrength
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public Nullable<System.Guid> fldTeam { get; set; }
        public Nullable<System.DateTime> fldAllocationDate { get; set; }
        public Nullable<System.Guid> fldAllocatedWorkerID { get; set; }
        public Nullable<int> fldReviewNo { get; set; }
        public Nullable<System.DateTime> fldDateFinalised { get; set; }
        public Nullable<System.Guid> fldPrimaryCarerID { get; set; }
        public Nullable<System.Guid> fldSecondaryCarerID { get; set; }
        public Nullable<System.Guid> fldOtherAdult1ID { get; set; }
        public Nullable<System.Guid> fldOtherAdult2ID { get; set; }
        public Nullable<bool> fldIsFamilyDesire { get; set; }
        public Nullable<bool> fldAboriginalorTorres { get; set; }
        public Nullable<bool> fldIsRefugee { get; set; }
        public Nullable<System.Guid> fldWorkerSuperviserId { get; set; }
        public Nullable<System.DateTime> fldDate { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<bool> fldActive { get; set; }
        public bool fldIsInitialFSNA { get; set; }
        public bool fldIsReview { get; set; }
        public Nullable<System.Guid> fldPersonCaseNumberFamilyId { get; set; }
        public Nullable<System.Guid> fldFamilyDesireContactPersonId { get; set; }
        public Nullable<System.Guid> fldFamilyDesireContactOrganisationId { get; set; }
        public bool fldAboriginalorTorresUnknown { get; set; }
        public bool fldIsRefugeeUnknown { get; set; }
        public Nullable<System.Guid> fldFamilyCultureId { get; set; }
    }
}
