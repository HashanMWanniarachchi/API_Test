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
    
    public partial class tblMealsPackage
    {
        public System.Guid fldID { get; set; }
        public string fldPackageName { get; set; }
        public string fldDescription { get; set; }
        public System.DateTime fldDateCreated { get; set; }
        public System.DateTime fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public byte fldActive { get; set; }
        public byte fldEdit { get; set; }
        public Nullable<decimal> fldPrice { get; set; }
        public Nullable<int> fldNumberMeals { get; set; }
        public bool fldUseMenuPrices { get; set; }
        public int fldUseForImports { get; set; }
        public bool fldBulkMealsPackage { get; set; }
        public string fldExtrasCode { get; set; }
    }
}