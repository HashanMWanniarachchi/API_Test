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
    
    public partial class tblRecurrenceDayOfMonth
    {
        public System.Guid fldRecurrenceDayOfMonthId { get; set; }
        public bool fldActive { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<System.Guid> fldRecurrenceId { get; set; }
        public Nullable<int> fldDayOfMonth { get; set; }
        public Nullable<int> fldWeek { get; set; }
        public Nullable<int> fldDayOfWeek { get; set; }
    }
}