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
    
    public partial class tblPathwayWorkflow
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldSectionID { get; set; }
        public bool fldGoToQuestion { get; set; }
        public Nullable<System.Guid> fldGoToID { get; set; }
        public Nullable<int> fldNextStepType { get; set; }
        public Nullable<System.Guid> fldNextStepID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<int> fldOrder { get; set; }
    }
}
