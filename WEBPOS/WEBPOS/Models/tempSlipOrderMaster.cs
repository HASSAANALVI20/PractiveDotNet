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
    
    public partial class tempSlipOrderMaster
    {
        public int auto_id { get; set; }
        public string orderTrackingId { get; set; }
        public Nullable<System.DateTime> orderDate { get; set; }
        public string orderTime { get; set; }
        public Nullable<int> orderNumber { get; set; }
        public string tableNumber { get; set; }
        public Nullable<int> punchUserId { get; set; }
        public string waiterName { get; set; }
        public Nullable<int> dayId { get; set; }
        public Nullable<int> shiftId { get; set; }
        public Nullable<int> counterId { get; set; }
        public string orderType { get; set; }
        public Nullable<System.DateTime> datetime { get; set; }
        public Nullable<int> billCount { get; set; }
        public Nullable<bool> isDelete { get; set; }
        public Nullable<int> deleteUserId { get; set; }
        public string deleteReason { get; set; }
        public Nullable<int> cashUserId { get; set; }
        public string orderStatus { get; set; }
        public string paymentStatus { get; set; }
        public Nullable<int> cover { get; set; }
        public Nullable<int> customerId { get; set; }
        public Nullable<double> subTotal { get; set; }
        public Nullable<double> taxAmount { get; set; }
        public Nullable<double> totalWithTax { get; set; }
        public Nullable<double> discountAmount { get; set; }
        public Nullable<double> discountPercent { get; set; }
        public Nullable<int> orderSubgroupId { get; set; }
        public Nullable<double> commissionPercent { get; set; }
        public Nullable<double> commissionAmount { get; set; }
        public Nullable<double> deliveryCharges { get; set; }
        public Nullable<double> extraCharges { get; set; }
        public Nullable<double> voucherAmount { get; set; }
        public Nullable<double> netAmount { get; set; }
        public Nullable<double> netAmountReceivable { get; set; }
        public Nullable<int> timeSlotId { get; set; }
        public Nullable<bool> isHold { get; set; }
        public Nullable<double> cashBackAmount { get; set; }
        public Nullable<int> discountDetailId { get; set; }
        public Nullable<int> mainTiltId { get; set; }
        public string slipNumber { get; set; }
    }
}
