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
    
    public partial class tblINIParticipantsHistory
    {
        public System.Guid fldIDHistoryID { get; set; }
        public Nullable<System.Guid> fldID { get; set; }
        public string fldName { get; set; }
        public Nullable<System.Guid> fldRelationship { get; set; }
        public string fldContactPhone { get; set; }
        public string fldOtherDetails { get; set; }
        public Nullable<System.Guid> fldINIID { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<byte> fldActive { get; set; }
        public bool fldPlanning { get; set; }
        public bool fldCopy { get; set; }
        public bool fldConsumer { get; set; }
    }
}
