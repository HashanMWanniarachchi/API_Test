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
    
    public partial class tblIncidentWitness
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldIncidentID { get; set; }
        public string fldWitnessName { get; set; }
        public Nullable<System.Guid> fldGenderID { get; set; }
        public Nullable<System.DateTime> fldDateOfBirth { get; set; }
        public string fldPosition { get; set; }
        public string fldLocation { get; set; }
        public string fldPhone { get; set; }
        public Nullable<int> fldParticipant { get; set; }
        public bool fldInjured { get; set; }
        public bool fldMedicalAttentionRequired { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public bool fldAboriginal { get; set; }
        public string fldInjuries { get; set; }
        public string fldFirstName { get; set; }
        public string fldLastName { get; set; }
        public Nullable<byte> fldPersonType { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public Nullable<int> fldPaidStaff { get; set; }
        public Nullable<System.Guid> fldPersonTypeId { get; set; }
        public Nullable<System.Guid> fldInjuryTypeId { get; set; }
        public Nullable<System.Guid> fldInjuryAffectedAreaId { get; set; }
        public Nullable<System.DateTime> fldParentGuardianInformed { get; set; }
    }
}
