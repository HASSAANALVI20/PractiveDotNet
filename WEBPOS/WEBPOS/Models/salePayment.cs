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
    
    public partial class salePayment
    {
        public int paymentId { get; set; }
        public string orderTrackingId { get; set; }
        public Nullable<int> shiftId { get; set; }
        public Nullable<int> counterId { get; set; }
        public Nullable<int> paymentTypeId { get; set; }
        public Nullable<double> netAmount { get; set; }
        public Nullable<double> receivedAmount { get; set; }
        public Nullable<double> returnAmount { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> tiltId { get; set; }
    }
}
