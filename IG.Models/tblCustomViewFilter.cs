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
    
    public partial class tblCustomViewFilter
    {
        public System.Guid fldID { get; set; }
        public Nullable<System.Guid> fldCustomViewId { get; set; }
        public string fldFieldName { get; set; }
        public string fldCompareOperator { get; set; }
        public Nullable<System.Guid> fldFilterValueGuid { get; set; }
        public string fldFilterValueString { get; set; }
        public Nullable<int> fldFilterValueInt { get; set; }
        public Nullable<int> fldFilterValueType { get; set; }
        public string fldDescription { get; set; }
        public string fldTableName { get; set; }
        public string fldExpression { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public byte fldActive { get; set; }
        public Nullable<System.DateTime> fldFilterValueDate { get; set; }
        public int fldColor { get; set; }
        public Nullable<System.Guid> fldLinkId { get; set; }
        public Nullable<System.DateTime> fldFilterValueDateRangeLower { get; set; }
        public Nullable<System.DateTime> fldFilterValueDateRangeUpper { get; set; }
        public Nullable<decimal> fldFilterValueDecimal { get; set; }
    }
}