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
    
    public partial class tblLogEvent
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldSessionID { get; set; }
        public System.DateTime fldTimestamp { get; set; }
        public int fldLevel { get; set; }
        public string fldModule { get; set; }
        public string fldMessage { get; set; }
        public byte[] fldData { get; set; }
    }
}
