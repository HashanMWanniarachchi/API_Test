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
    
    public partial class tblEquipment
    {
        public System.Guid fldEquipmentID { get; set; }
        public System.Guid fldPersonID { get; set; }
        public System.Guid fldEquipmentTypeID { get; set; }
        public string fldEquipmentDescription { get; set; }
        public string fldSerialNumber { get; set; }
        public Nullable<System.DateTime> fldIssueDate { get; set; }
        public Nullable<System.DateTime> fldDueDate { get; set; }
        public Nullable<System.DateTime> fldReturnDate { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.DateTime> fldPurchaseDate { get; set; }
        public string fldAddress { get; set; }
        public Nullable<decimal> fldCost { get; set; }
        public string fldPurchasedFrom { get; set; }
        public Nullable<int> fldOwnedBy { get; set; }
        public Nullable<System.Guid> fldOwnedByID { get; set; }
        public string fldOwnedByOther { get; set; }
        public string fldMaintainedBy { get; set; }
        public string fldMaintenanceContact { get; set; }
        public string fldOtherContact { get; set; }
    }
}
