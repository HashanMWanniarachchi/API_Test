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
    
    public partial class tblServiceOutputDetail
    {
        public System.Guid fldID { get; set; }
        public System.Guid fldServiceOutputHeaderId { get; set; }
        public string fldDescription { get; set; }
        public System.DateTime fldDateFrom { get; set; }
        public System.DateTime fldDateTo { get; set; }
        public Nullable<decimal> fldTargetClients { get; set; }
        public Nullable<decimal> fldTargetHours { get; set; }
        public byte fldTargetClientRequired { get; set; }
        public byte fldTargetHoursRequired { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
    }
}