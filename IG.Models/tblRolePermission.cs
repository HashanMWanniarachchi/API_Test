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
    
    public partial class tblRolePermission
    {
        public System.Guid fldRoleId { get; set; }
        public System.Guid fldPermissionId { get; set; }
        public Nullable<int> fldRights { get; set; }
        public System.Guid fldRolePermissionId { get; set; }
    
        public virtual tblPermission tblPermission { get; set; }
        public virtual tblRole tblRole { get; set; }
    }
}