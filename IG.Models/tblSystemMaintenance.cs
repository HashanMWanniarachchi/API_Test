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
    
    public partial class tblSystemMaintenance
    {
        public string fldTableName { get; set; }
        public string fldTableFriendlyName { get; set; }
        public byte fldAllowPreference { get; set; }
        public Nullable<byte> fldPattern { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserID { get; set; }
        public byte fldActive { get; set; }
        public byte fldEdit { get; set; }
        public string fldGroupName { get; set; }
        public string fldPrimaryField { get; set; }
        public System.Guid fldSystemMaintenanceID { get; set; }
        public Nullable<byte> fldVisible { get; set; }
        public Nullable<int> fldUserPermission { get; set; }
    }
}