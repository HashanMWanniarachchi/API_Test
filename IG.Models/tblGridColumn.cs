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
    
    public partial class tblGridColumn
    {
        public System.Guid fldGridColumnId { get; set; }
        public Nullable<System.Guid> fldViewTypeId { get; set; }
        public string fldHeaderText { get; set; }
        public string fldTextAlign { get; set; }
        public string fldDataRowFieldName { get; set; }
        public string fldFormatStyle { get; set; }
        public string fldCellType { get; set; }
        public string fldCellValueType { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public string fldInputMask { get; set; }
        public bool fldMandatory { get; set; }
        public bool fldVisible { get; set; }
        public string fldComboSource { get; set; }
        public string fldComboValueMember { get; set; }
        public string fldComboDisplayMember { get; set; }
        public Nullable<int> fldWidth { get; set; }
        public Nullable<int> fldOrder { get; set; }
        public bool fldEnabled { get; set; }
        public Nullable<int> fldVersion { get; set; }
    }
}
