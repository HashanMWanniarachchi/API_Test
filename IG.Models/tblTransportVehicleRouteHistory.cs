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
    
    public partial class tblTransportVehicleRouteHistory
    {
        public System.Guid fldTransportVehicleRouteHistoryId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public bool fldActive { get; set; }
        public Nullable<System.Guid> fldRecurrenceGeneratedDateId { get; set; }
        public Nullable<System.Guid> fldRecurrenceId { get; set; }
        public bool fldIsManuallyEdited { get; set; }
        public Nullable<System.Guid> fldStartLocationId { get; set; }
        public Nullable<System.Guid> fldEndLocationId { get; set; }
        public Nullable<System.Guid> fldTransportVehicleRouteRuleId { get; set; }
        public Nullable<System.Guid> fldPersonId { get; set; }
        public string fldJourneyNumber { get; set; }
        public Nullable<System.Guid> fldVehicleId { get; set; }
        public Nullable<bool> fldIsSingleDestination { get; set; }
        public Nullable<System.Guid> fldVehicleStatusId { get; set; }
        public Nullable<System.Guid> fldTransportVehicleRouteId { get; set; }
        public Nullable<System.DateTime> fldInactiveStartTime { get; set; }
        public Nullable<System.DateTime> fldInactiveEndTime { get; set; }
    }
}