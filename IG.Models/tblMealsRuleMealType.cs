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
    
    public partial class tblMealsRuleMealType
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldRosterRuleID { get; set; }
        public Nullable<System.Guid> fldMealsPackageTypeID { get; set; }
        public Nullable<System.Guid> fldMealsTypeID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
    }
}