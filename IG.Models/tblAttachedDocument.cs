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
    
    public partial class tblAttachedDocument
    {
        public System.Guid fldAttatchedDocID { get; set; }
        public System.Guid fldDocumentTypeID { get; set; }
        public string fldFileName { get; set; }
        public string fldAttachedDocDesc { get; set; }
        public byte[] fldDocument { get; set; }
        public string fldMime { get; set; }
        public System.Guid fldPersonID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldForeignId { get; set; }
        public bool fldArchived { get; set; }
        public bool fldStoredInDatabase { get; set; }
        public Nullable<System.Guid> fldArchiveReason { get; set; }
        public int fldCompressionType { get; set; }
        public bool fldMobileDocument { get; set; }
        public int fldForeignType { get; set; }
    }
}