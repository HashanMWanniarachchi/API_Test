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
    
    public partial class tblOutOfHomeCareIncident
    {
        public System.Guid fldIncidentId { get; set; }
        public System.Guid fldOutOfHomeCareId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.DateTime> fldIncidentDate { get; set; }
        public Nullable<System.Guid> fldIncidentType { get; set; }
        public string fldIncidentDetail { get; set; }
        public string fldIncidentReference { get; set; }
        public string fldIncidentOutcome { get; set; }
    }
}
