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
    
    public partial class tblGrandparentsActivityPreference
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldMainID { get; set; }
        public Nullable<System.Guid> fldActivity { get; set; }
        public Nullable<System.DateTime> fldContactDate { get; set; }
        public Nullable<System.DateTime> fldReferralDate { get; set; }
        public Nullable<System.DateTime> fldApprovalDate { get; set; }
        public Nullable<System.DateTime> fldActivityDate { get; set; }
        public string fldServiceProvider { get; set; }
        public string fldClientWaitingList { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
    }
}
