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
    
    public partial class tblPersonTraining
    {
        public System.Guid fldTrainingID { get; set; }
        public System.Guid fldPersonID { get; set; }
        public System.DateTime fldStartDate { get; set; }
        public Nullable<System.DateTime> fldFinishDate { get; set; }
        public Nullable<System.DateTime> fldCompletedDate { get; set; }
        public Nullable<byte> fldPassed { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public System.Guid fldUserId { get; set; }
        public byte fldActive { get; set; }
    }
}
