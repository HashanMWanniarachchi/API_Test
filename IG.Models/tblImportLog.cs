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
    
    public partial class tblImportLog
    {
        public int fldID { get; set; }
        public bool fldRejected { get; set; }
        public Nullable<System.DateTime> fldDateImported { get; set; }
        public Nullable<System.DateTime> fldTimeImported { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.DateTime> fldTimeUpdated { get; set; }
        public string fldUpdatedBy { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public Nullable<System.DateTime> fldStartTime { get; set; }
        public Nullable<System.DateTime> fldEndTime { get; set; }
        public Nullable<System.Guid> fldCarerID { get; set; }
        public Nullable<System.Guid> fldClientID { get; set; }
    }
}