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
    
    public partial class tblReportScheduleLog
    {
        public System.Guid fldID { get; set; }
        public System.Guid fldScheduleID { get; set; }
        public System.DateTime fldStarted { get; set; }
        public System.DateTime fldCompleted { get; set; }
        public byte fldManual { get; set; }
        public int fldOutcome { get; set; }
        public string fldMessage { get; set; }
    }
}