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
    
    public partial class orderDetail
    {
        public int orderDetailId { get; set; }
        public string orderTrackingId { get; set; }
        public Nullable<int> itemId { get; set; }
        public Nullable<int> categoryId { get; set; }
        public Nullable<double> quantity { get; set; }
        public Nullable<double> salePrice { get; set; }
        public Nullable<double> subTotal { get; set; }
        public Nullable<double> itemDiscount { get; set; }
        public Nullable<double> totalAmount { get; set; }
        public Nullable<double> tax { get; set; }
        public string itemComment { get; set; }
        public Nullable<bool> isCompliment { get; set; }
        public Nullable<int> counterId { get; set; }
        public Nullable<System.DateTime> itemTime { get; set; }
        public Nullable<bool> kot { get; set; }
        public Nullable<bool> isUpdate { get; set; }
        public Nullable<bool> isNew { get; set; }
        public Nullable<int> deviceDetailId { get; set; }
        public Nullable<bool> isTransfer { get; set; }
    
        public virtual addItem addItem { get; set; }
    }
}