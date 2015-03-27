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
    
    public partial class tblRole
    {
        public tblRole()
        {
            this.AcpTemplatePermissions = new HashSet<AcpTemplatePermission>();
            this.tblRoleCaseTypes = new HashSet<tblRoleCaseType>();
            this.tblRoleNoteTypes = new HashSet<tblRoleNoteType>();
            this.tblRolePermissions = new HashSet<tblRolePermission>();
            this.tblUserRoles = new HashSet<tblUserRole>();
        }
    
        public System.Guid fldRoleId { get; set; }
        public string fldRoleName { get; set; }
        public string fldDescription { get; set; }
        public bool fldActive { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
    
        public virtual ICollection<AcpTemplatePermission> AcpTemplatePermissions { get; set; }
        public virtual ICollection<tblRoleCaseType> tblRoleCaseTypes { get; set; }
        public virtual ICollection<tblRoleNoteType> tblRoleNoteTypes { get; set; }
        public virtual ICollection<tblRolePermission> tblRolePermissions { get; set; }
        public virtual ICollection<tblUserRole> tblUserRoles { get; set; }
    }
}
