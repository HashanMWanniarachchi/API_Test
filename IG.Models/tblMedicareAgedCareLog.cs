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
    
    public partial class tblMedicareAgedCareLog
    {
        public System.Guid fldMedicareAgedCareLogID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public Nullable<System.Guid> fldServicesRequiredID { get; set; }
        public Nullable<System.Guid> fldLeaveID { get; set; }
        public Nullable<System.Guid> fldAddressID { get; set; }
        public Nullable<System.Guid> fldFundingBodyID { get; set; }
        public Nullable<System.DateTime> fldStartDate { get; set; }
        public Nullable<System.DateTime> fldEndDate { get; set; }
        public string fldMonth { get; set; }
        public string fldEventID { get; set; }
        public Nullable<int> fldSequenceNumber { get; set; }
        public string fldEventType { get; set; }
        public string fldReClaimType { get; set; }
        public string fldEventStatus { get; set; }
        public Nullable<System.DateTime> fldEventStatusUpdated { get; set; }
        public string fldMessageStatus { get; set; }
        public string fldMessageProcessingType { get; set; }
        public string fldMessageProcessingCode { get; set; }
        public string fldMessageProcessingText { get; set; }
        public string fldEventProcessingType { get; set; }
        public string fldEventProcessingCode { get; set; }
        public string fldEventProcessingText { get; set; }
        public string fldProviderNumber { get; set; }
        public Nullable<System.DateTime> fldEntryDate { get; set; }
        public Nullable<int> fldHours { get; set; }
        public Nullable<int> fldMinutes { get; set; }
        public string fldSuburb { get; set; }
        public Nullable<int> fldPostcode { get; set; }
        public string fldDepartureCode { get; set; }
        public Nullable<System.DateTime> fldDepartureDate { get; set; }
        public Nullable<int> fldLeaveCode { get; set; }
        public Nullable<System.DateTime> fldLeaveStart { get; set; }
        public Nullable<System.DateTime> fldLeaveEnd { get; set; }
        public Nullable<System.DateTime> fldLocationDate { get; set; }
        public bool fldFinalized { get; set; }
        public bool fldResubmit { get; set; }
        public bool fldFinancialHardship { get; set; }
        public string fldLocationID { get; set; }
        public string fldAuthorisedSurname { get; set; }
        public string fldAuthorisedFirstname { get; set; }
        public Nullable<int> fldExcessCareRecipients { get; set; }
    }
}
