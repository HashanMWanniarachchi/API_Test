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
    
    public partial class tblDVAMDSPeriod
    {
        public System.Guid fldDVAMDSPeriodsID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldClientID { get; set; }
        public string fldItemNumber { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public bool fldConsumable { get; set; }
        public Nullable<System.Guid> fldDVAItemNumberID { get; set; }
        public Nullable<System.DateTime> fldDVAMDSPeriodFreqEnd { get; set; }
        public bool fldExported { get; set; }
    }
}
