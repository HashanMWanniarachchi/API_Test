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
    
    public partial class tblRate
    {
        public System.Guid fldRatesID { get; set; }
        public Nullable<System.Guid> fldScheduleRatesID { get; set; }
        public Nullable<decimal> fldLowerLimit { get; set; }
        public Nullable<decimal> fldUpperLimit { get; set; }
        public Nullable<decimal> fldRate { get; set; }
        public byte fldFlatRate { get; set; }
        public Nullable<System.Guid> fldIncomeLevel { get; set; }
        public string fldCode { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldActivityId { get; set; }
        public Nullable<System.Guid> fldNDISSupportNumberID { get; set; }
    }
}
