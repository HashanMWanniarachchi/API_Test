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
    
    public partial class tblResidentialServicesGoal
    {
        public System.Guid fldResidentialServicesGoalsID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldResidentialServicesID { get; set; }
        public string fldAction { get; set; }
        public string fldResponsibility { get; set; }
        public Nullable<System.DateTime> fldBy { get; set; }
        public bool fldCompleted { get; set; }
        public string fldEvaluation { get; set; }
        public Nullable<int> fldType { get; set; }
        public bool fldNoAction { get; set; }
    }
}
