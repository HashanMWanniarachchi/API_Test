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
    
    public partial class tblWorkflowNotification
    {
        public System.Guid fldWorkflowNotificationId { get; set; }
        public System.Guid fldTriggerId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public byte fldActive { get; set; }
        public System.Guid fldUserId { get; set; }
        public short fldNotificationType { get; set; }
        public string fldNotificationText { get; set; }
        public Nullable<System.Guid> fldNotificationId { get; set; }
    }
}
