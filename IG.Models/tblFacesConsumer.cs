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
    
    public partial class tblFacesConsumer
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldFacesID { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public bool fldLivesWithConsumer { get; set; }
        public Nullable<int> fldCarerRelationship { get; set; }
        public Nullable<int> fldConsumerAgeGroup { get; set; }
        public int fldAHSContract { get; set; }
        public int fldHealthManaged { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public bool fldOtherDisability { get; set; }
        public string fldOtherDisabilityDesc { get; set; }
        public Nullable<int> fldConsumerNumber { get; set; }
        public Nullable<System.Guid> fldConsumerAgeGroupId { get; set; }
    }
}
