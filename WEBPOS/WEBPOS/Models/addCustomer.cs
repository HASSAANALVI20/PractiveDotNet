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
    
    public partial class addCustomer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerMobile1 { get; set; }
        public string customerMobile2 { get; set; }
        public string customerAddress { get; set; }
        public Nullable<System.DateTime> addedDate { get; set; }
        public Nullable<bool> customerEnable { get; set; }
    }
}