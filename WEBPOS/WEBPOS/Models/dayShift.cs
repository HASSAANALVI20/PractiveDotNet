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
    
    public partial class dayShift
    {
        public int shiftId { get; set; }
        public string shiftNumber { get; set; }
        public string shiftName { get; set; }
        public Nullable<System.DateTime> openDate { get; set; }
        public string openTime { get; set; }
        public Nullable<System.DateTime> closeDate { get; set; }
        public string CloseTime { get; set; }
        public Nullable<int> shiftOpenId { get; set; }
        public Nullable<int> shiftCloseId { get; set; }
        public Nullable<int> shiftOpenCounterId { get; set; }
        public Nullable<int> shiftCloseCounterId { get; set; }
        public Nullable<int> dayId { get; set; }
        public Nullable<bool> shiftActive { get; set; }
    }
}
