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
    
    public partial class tblServiceHistory
    {
        public System.Guid fldServiceIDHistoryID { get; set; }
        public Nullable<System.Guid> fldServiceID { get; set; }
        public string fldServiceName { get; set; }
        public Nullable<System.DateTime> fldDateCreated { get; set; }
        public Nullable<System.DateTime> fldDateUpdated { get; set; }
        public Nullable<System.Guid> fldUserId { get; set; }
        public Nullable<byte> fldActive { get; set; }
        public Nullable<System.Guid> fldAwardID { get; set; }
        public Nullable<byte> fldEdit { get; set; }
        public string fldExportCode { get; set; }
        public Nullable<System.Guid> fldPaybandID { get; set; }
        public Nullable<int> fldMDSCode { get; set; }
        public Nullable<int> fldTACCode { get; set; }
        public Nullable<byte> fldMealsService { get; set; }
        public Nullable<bool> fldCentreBasedService { get; set; }
        public Nullable<decimal> fldPayHours { get; set; }
        public Nullable<bool> fldIgnoreCoreHours { get; set; }
        public Nullable<bool> fldIsMakeUpPayService { get; set; }
        public Nullable<bool> fldIsLeaveService { get; set; }
        public Nullable<bool> fldExportLeaveToPayroll { get; set; }
        public Nullable<bool> fldReferralService { get; set; }
        public Nullable<bool> fldIsHomeMaintenanceService { get; set; }
        public Nullable<System.Guid> fldHomeMaintenanceType { get; set; }
        public Nullable<System.Guid> fldServiceCategoryID { get; set; }
        public string fldNRCPService { get; set; }
        public Nullable<bool> fldIsTransportService { get; set; }
        public Nullable<bool> fldIsSleepover { get; set; }
        public Nullable<int> fldAlliedHealthType { get; set; }
        public string fldServiceCode { get; set; }
        public Nullable<int> fldCSTDAService { get; set; }
        public Nullable<System.Guid> fldExternalServiceId { get; set; }
        public string fldTAHDefaultCode { get; set; }
        public string fldTAHAfter5Code { get; set; }
        public string fldTAHPrior1987Code { get; set; }
        public Nullable<bool> fldBreakEvenService { get; set; }
        public Nullable<bool> fldChargeFundingBody { get; set; }
        public string fldMealsDeliveryCode { get; set; }
        public bool fldExcludeFromPayroll { get; set; }
        public Nullable<System.Guid> fldClashingCarerId { get; set; }
        public bool fldIsFRCService { get; set; }
        public Nullable<System.Guid> fldKilometrePayrateID { get; set; }
        public bool fldExcludeFromAverageHours { get; set; }
        public Nullable<bool> fldIsLeaveBreak { get; set; }
        public Nullable<System.Guid> fldNoteType { get; set; }
        public Nullable<System.Guid> fldCarePlanTemplate { get; set; }
        public bool fldExcludeFromPH { get; set; }
        public Nullable<bool> fldExcludeFromDVA { get; set; }
        public bool fldFundingPromptEnabled { get; set; }
        public string fldFundingPrompt { get; set; }
        public Nullable<System.Guid> fldRRSPServiceTypeID { get; set; }
        public bool fldRRSPReportedService { get; set; }
        public Nullable<System.Guid> fldQDCSubActivityID { get; set; }
        public bool fldUsePayHoursFinPack { get; set; }
        public Nullable<bool> fldChargePerIncomeLevelMandatory { get; set; }
        public bool fldIncludeMealsExports { get; set; }
        public bool fldOutOfHomeCareService { get; set; }
        public Nullable<bool> fldAutoApprove { get; set; }
        public bool fldDEEWRService { get; set; }
        public bool fldExcludeFromTravel { get; set; }
        public bool fldExcludeFromMapping { get; set; }
        public bool fldExcludeFromInvoiceExport { get; set; }
        public bool fldExcludeFromPayrollExport { get; set; }
        public bool fldRequestedHours { get; set; }
        public bool fldExcludeFromAllowanceCalculation { get; set; }
        public Nullable<System.Guid> fldNDISSupportNumberID { get; set; }
        public bool fldExcludeFromCdcInternalOutgoings { get; set; }
        public Nullable<System.Guid> fldMHCSSServices { get; set; }
    }
}