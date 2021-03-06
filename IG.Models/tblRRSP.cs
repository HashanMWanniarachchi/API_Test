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
    
    public partial class tblRRSP
    {
        public System.Guid fldID { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.Guid> fldPersonID { get; set; }
        public bool fldActiveMentalHealthServiceClient { get; set; }
        public bool fldPrimarySchizophrenia { get; set; }
        public bool fldPrimaryBipolarDisorder { get; set; }
        public bool fldPrimarySchizoAffectiveDisorder { get; set; }
        public bool fldPrimaryPersonalityDisorder { get; set; }
        public bool fldPrimaryDepressionAnxiety { get; set; }
        public bool fldPrimarySocialIssue { get; set; }
        public bool fldPrimaryMentalIllnessOther { get; set; }
        public bool fldSecondarySchizophrenia { get; set; }
        public bool fldSecondaryBipolarDisorder { get; set; }
        public bool fldSecondarySchizoAffectiveDisorder { get; set; }
        public bool fldSecondaryPersonalityDisorder { get; set; }
        public bool fldSecondaryDepressionAnxiety { get; set; }
        public bool fldSecondarySocialIssue { get; set; }
        public bool fldSecondaryMentalIllnessOther { get; set; }
        public string fldMentalIllnessOther { get; set; }
        public bool fldSubstanceAbuse { get; set; }
        public bool fldIntellectualDisability { get; set; }
        public bool fldPhysicalHealthIssues { get; set; }
        public bool fldPhysicalDisability { get; set; }
        public bool fldBrainInjury { get; set; }
        public bool fldSocioEconomic { get; set; }
        public bool fldCoexistingOther { get; set; }
        public string fldCoexistingOtherFactors { get; set; }
        public Nullable<bool> fldSecureTenancyAtApplication { get; set; }
        public Nullable<System.Guid> fldApplicationOutcomeID { get; set; }
        public string fldOutcomeReason { get; set; }
        public Nullable<System.DateTime> fldSupportCommencedDate { get; set; }
        public Nullable<System.DateTime> fldForm2CompletionDate { get; set; }
        public Nullable<System.DateTime> fldForm1CompletionDate { get; set; }
        public Nullable<System.Guid> fldAPQ6AssessmentID { get; set; }
        public Nullable<bool> fldConsumerExited { get; set; }
        public Nullable<System.Guid> fldExitReasonID { get; set; }
        public string fldExitReasonOther { get; set; }
        public Nullable<System.DateTime> fldExitDate { get; set; }
        public Nullable<System.Guid> fldGoalSocialCommunity { get; set; }
        public Nullable<System.Guid> fldGoalLeisureRecreation { get; set; }
        public Nullable<System.Guid> fldGoalEducation { get; set; }
        public Nullable<System.Guid> fldGoalVocationalEngagement { get; set; }
        public Nullable<System.Guid> fldGoalEmployment { get; set; }
        public Nullable<System.Guid> fldGoalCulturalConnection { get; set; }
    }
}
