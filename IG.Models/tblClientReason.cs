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
    
    public partial class tblClientReason
    {
        public System.Guid fldClientReasonID { get; set; }
        public string fldClientReason { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public byte fldEdit { get; set; }
        public string fldDVABreakInEpisodeCode { get; set; }
        public bool fldBreakEven { get; set; }
        public string fldEachCode { get; set; }
        public string fldCACPCode { get; set; }
    }
}