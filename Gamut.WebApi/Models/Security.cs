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
    
    public partial class Security
    {
        public int Id { get; set; }
        public string Cust_Id { get; set; }
        public string accountNo { get; set; }
        public string securityType { get; set; }
        public Nullable<double> balanceAsOn { get; set; }
        public string securityDetails { get; set; }
        public Nullable<double> apportionValue { get; set; }
        public string correctFlag { get; set; }
        public Nullable<double> insuranceValue { get; set; }
        public Nullable<System.DateTime> ìnsuranceExpiryDate { get; set; }
        public Nullable<System.DateTime> followUpDate { get; set; }
        public string coverage { get; set; }
        public string guarantorId { get; set; }
        public Nullable<double> guarantorNetWorth { get; set; }
        public string LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedOn { get; set; }
    }
}
