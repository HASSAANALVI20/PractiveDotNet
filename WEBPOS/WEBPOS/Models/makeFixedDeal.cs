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
    
    public partial class makeFixedDeal
    {
        public int incId { get; set; }
        public Nullable<int> fixedDealId { get; set; }
        public Nullable<int> categoryId { get; set; }
        public Nullable<int> itemId { get; set; }
        public Nullable<double> quantity { get; set; }
        public Nullable<System.DateTime> addedDate { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
    }
}