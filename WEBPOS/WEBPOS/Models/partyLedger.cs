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
    
    public partial class partyLedger
    {
        public int ledgerId { get; set; }
        public int customerId { get; set; }
        public string orderTrackingId { get; set; }
        public string type { get; set; }
        public double amount { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<double> balance { get; set; }
        public Nullable<int> shiftId { get; set; }
        public Nullable<int> tiltId { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> counterId { get; set; }
    }
}
