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
    
    public partial class AcpSectionQuestion
    {
        public AcpSectionQuestion()
        {
            this.AcpWorkflowRules = new HashSet<AcpWorkflowRule>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid AcpSectionId { get; set; }
        public Nullable<System.Guid> AcpQuestionId { get; set; }
        public Nullable<System.Guid> DatabaseQuestionId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsMandatoryField { get; set; }
        public bool IsTrackChanges { get; set; }
        public bool IsPercentageComplete { get; set; }
        public short ReAssessmentPeriod { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string DatabaseQuestionToolTip { get; set; }
    
        public virtual AcpDatabaseQuestion AcpDatabaseQuestion { get; set; }
        public virtual AcpQuestion AcpQuestion { get; set; }
        public virtual AcpSection AcpSection { get; set; }
        public virtual tblUser tblUser { get; set; }
        public virtual ICollection<AcpWorkflowRule> AcpWorkflowRules { get; set; }
    }
}