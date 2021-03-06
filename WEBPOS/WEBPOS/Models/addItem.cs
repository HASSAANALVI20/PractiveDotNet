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
    
    public partial class addItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public addItem()
        {
            this.orderDetail = new HashSet<orderDetail>();
            this.ReservationDetail = new HashSet<ReservationDetail>();
        }
    
        public int itemId { get; set; }
        public Nullable<int> categoryId { get; set; }
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public string alternateName { get; set; }
        public string itemUnit { get; set; }
        public Nullable<double> costPrice { get; set; }
        public Nullable<double> salePrice { get; set; }
        public Nullable<bool> allowTax { get; set; }
        public Nullable<bool> allowKot { get; set; }
        public Nullable<bool> allowDiscount { get; set; }
        public Nullable<bool> allowComment { get; set; }
        public Nullable<bool> itemActive { get; set; }
        public Nullable<System.DateTime> addedDate { get; set; }
        public Nullable<int> addUserId { get; set; }
        public Nullable<System.DateTime> modifiedDate { get; set; }
        public Nullable<int> modifyUserId { get; set; }
        public Nullable<bool> allowTopping { get; set; }
        public Nullable<bool> isDealItem { get; set; }
        public string itemType { get; set; }
        public string printer { get; set; }
        public Nullable<bool> applyDate { get; set; }
        public Nullable<bool> applyTime { get; set; }
        public Nullable<System.DateTime> dateFrom { get; set; }
        public Nullable<System.DateTime> dateTo { get; set; }
        public string timeFrom { get; set; }
        public string timeTo { get; set; }
        public string colorCode { get; set; }
        public string imageName { get; set; }
        public Nullable<bool> HnH { get; set; }
        public Nullable<int> itemSequence { get; set; }
        public Nullable<double> discPercent { get; set; }
        public Nullable<double> discAmount { get; set; }
    
        public virtual addCategory addCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderDetail> orderDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationDetail> ReservationDetail { get; set; }
    }
}
