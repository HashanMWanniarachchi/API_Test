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
    
    public partial class tblEziPaySetting
    {
        public bool fldApproveAutoLogouts { get; set; }
        public Nullable<int> fldKilometreTolerance { get; set; }
        public Nullable<int> fldTravelTimeTolerance { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public System.Guid fldEziPaySettingsID { get; set; }
        public Nullable<int> fldIntKilometreTolerance { get; set; }
    }
}
