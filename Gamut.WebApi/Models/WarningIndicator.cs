//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gamut.WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WarningIndicator
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> fromDate { get; set; }
        public Nullable<System.DateTime> toDate { get; set; }
        public Nullable<System.DateTime> asOnDate { get; set; }
        public string WarningSignal { get; set; }
        public string irregularities { get; set; }
        public Nullable<System.DateTime> observedOn { get; set; }
        public string observationRemarks { get; set; }
        public string actionFor { get; set; }
        public Nullable<System.DateTime> lastUpdatedOn { get; set; }
        public string lastUpdatedBy { get; set; }
        public string Cust_Id { get; set; }
    }
}