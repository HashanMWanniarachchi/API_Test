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
    
    public partial class tblFundingBodyService
    {
        public Nullable<System.Guid> fldFundingBodyID { get; set; }
        public System.Guid fldServiceID { get; set; }
        public Nullable<System.Guid> fldCostAccount { get; set; }
        public System.Guid fldFundingBodyServiceID { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<System.Guid> fldAddressId { get; set; }
        public Nullable<byte> fldActive { get; set; }
        public bool fldChargeFundingBody { get; set; }
        public bool fldCreateJournal { get; set; }
        public string fldInvoiceDescription { get; set; }
        public Nullable<decimal> fldJournalChargeRate { get; set; }
        public Nullable<System.Guid> fldJournalSchedule { get; set; }
        public bool fldNotifyAccountReceivable { get; set; }
    }
}