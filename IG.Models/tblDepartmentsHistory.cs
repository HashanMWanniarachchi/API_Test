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
    
    public partial class tblDepartmentsHistory
    {
        public System.Guid fldDepartmentIDHistoryID { get; set; }
        public Nullable<System.Guid> fldDepartmentID { get; set; }
        public string fldDepartmentName { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<byte> fldActive { get; set; }
        public Nullable<byte> fldEdit { get; set; }
        public string fldContact { get; set; }
        public string fldCaseNumberPrefix { get; set; }
        public Nullable<int> fldNextCaseNumber { get; set; }
    }
}
