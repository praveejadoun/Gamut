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
    
    public partial class ActivityLog
    {
        public int Id { get; set; }
        public string Cust_Id { get; set; }
        public string activityType { get; set; }
        public string logType { get; set; }
        public Nullable<System.DateTime> informationDate { get; set; }
        public string stepsTaken { get; set; }
        public string attachment { get; set; }
        public Nullable<System.DateTime> nextFollowupDate { get; set; }
        public Nullable<System.DateTime> ractificationDate { get; set; }
        public Nullable<System.DateTime> compiledDate { get; set; }
        public string lastUpdatedBy { get; set; }
        public Nullable<System.DateTime> lastUpdatedOn { get; set; }
    }
}
