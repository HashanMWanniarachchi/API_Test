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
    
    public partial class tblONIField
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldINIID { get; set; }
        public Nullable<bool> fldInsurance1 { get; set; }
        public Nullable<bool> fldInsurance2 { get; set; }
        public Nullable<bool> fldInsurance3 { get; set; }
        public Nullable<bool> fldInsurance4 { get; set; }
        public Nullable<bool> fldInsurance5 { get; set; }
        public Nullable<bool> fldInsurance6 { get; set; }
        public Nullable<bool> fldInsurance7 { get; set; }
        public Nullable<bool> fldInsurance99 { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public string fldCommunicationHelp { get; set; }
        public string fldInterpreterRequired { get; set; }
        public string fldFacility { get; set; }
        public string fldOfficerName { get; set; }
        public string fldOfficerDesignation { get; set; }
        public string fldAgency { get; set; }
        public string fldContactNumber { get; set; }
        public Nullable<System.DateTime> fldReportDate { get; set; }
    }
}