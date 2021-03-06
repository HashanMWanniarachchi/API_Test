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
    
    public partial class AcpWorkflow
    {
        public AcpWorkflow()
        {
            this.AcpWorkflowActions = new HashSet<AcpWorkflowAction>();
            this.AcpWorkflowRules = new HashSet<AcpWorkflowRule>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid AcpSectionId { get; set; }
        public int DisplayOrder { get; set; }
        public Nullable<System.Guid> OverrideCalculatedFieldSectionQuestionId { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
    
        public virtual AcpSection AcpSection { get; set; }
        public virtual ICollection<AcpWorkflowAction> AcpWorkflowActions { get; set; }
        public virtual ICollection<AcpWorkflowRule> AcpWorkflowRules { get; set; }
    }
}
