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
    
    public partial class tblRecurrenceItem
    {
        public System.Guid fldID { get; set; }
        public System.Guid fldRecurrenceRuleId { get; set; }
        public byte fldIsAltered { get; set; }
        public System.DateTime fldDate { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserID { get; set; }
        public byte fldActive { get; set; }
        public byte fldIsRejected { get; set; }
        public Nullable<System.DateTime> fldStartTime { get; set; }
        public Nullable<System.DateTime> fldEndTime { get; set; }
        public byte fldIsMasterItem { get; set; }
        public Nullable<int> fldItemType { get; set; }
    }
}
