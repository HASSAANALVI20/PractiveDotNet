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
    
    public partial class ReservationDetail
    {
        public int reservationDetailId { get; set; }
        public Nullable<int> reservationId { get; set; }
        public Nullable<int> itemId { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<double> quantity { get; set; }
        public Nullable<double> amount { get; set; }
    
        public virtual addItem addItem { get; set; }
        public virtual ReservationMaster ReservationMaster { get; set; }
    }
}
