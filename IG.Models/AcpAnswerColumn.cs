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
    
    public partial class AcpAnswerColumn
    {
        public System.Guid Id { get; set; }
        public System.Guid AnswerId { get; set; }
        public string ColumnName { get; set; }
        public int DisplayOrder { get; set; }
        public int ColumnType { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
    }
}
