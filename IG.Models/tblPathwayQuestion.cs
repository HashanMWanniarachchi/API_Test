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
    
    public partial class tblPathwayQuestion
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldSectionID { get; set; }
        public string fldQuestion { get; set; }
        public Nullable<int> fldAnswerType { get; set; }
        public bool fldMandatory { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<int> fldOrder { get; set; }
        public Nullable<System.Guid> fldDatabaseFieldID { get; set; }
        public bool fldLargeFont { get; set; }
        public bool fldLargeNoteBox { get; set; }
        public string fldToolTip { get; set; }
    }
}
