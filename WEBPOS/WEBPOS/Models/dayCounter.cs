//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBPOS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dayCounter
    {
        public int shiftCounterId { get; set; }
        public Nullable<int> counterId { get; set; }
        public Nullable<int> shiftId { get; set; }
        public Nullable<int> dayId { get; set; }
        public Nullable<int> counterOpenId { get; set; }
        public Nullable<double> openAmount { get; set; }
        public Nullable<int> counterCloseId { get; set; }
        public Nullable<double> closeAmount { get; set; }
        public Nullable<System.DateTime> openDate { get; set; }
        public string openTime { get; set; }
        public Nullable<System.DateTime> closeDate { get; set; }
        public string closeTime { get; set; }
        public Nullable<bool> counterActive { get; set; }
        public Nullable<int> denom5000 { get; set; }
        public Nullable<int> denom1000 { get; set; }
        public Nullable<int> denom500 { get; set; }
        public Nullable<int> denom100 { get; set; }
        public Nullable<int> denom50 { get; set; }
        public Nullable<int> denom20 { get; set; }
        public Nullable<int> denom10 { get; set; }
        public Nullable<int> denom5 { get; set; }
        public Nullable<int> denom2 { get; set; }
        public Nullable<int> denom1 { get; set; }
    }
}
