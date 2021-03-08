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
    
    public partial class ReservationMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReservationMaster()
        {
            this.ReservationDetail = new HashSet<ReservationDetail>();
        }
    
        public int reservationId { get; set; }
        public System.DateTime reservationDate { get; set; }
        public string reservationNumber { get; set; }
        public int customerId { get; set; }
        public Nullable<System.DateTime> reservedFrom { get; set; }
        public Nullable<System.DateTime> reservedTo { get; set; }
        public Nullable<int> adultGuest { get; set; }
        public Nullable<int> childGuest { get; set; }
        public Nullable<int> tableNo { get; set; }
        public Nullable<int> locationId { get; set; }
        public Nullable<bool> smokingArea { get; set; }
        public int userId { get; set; }
        public Nullable<System.DateTime> dateAdded { get; set; }
        public int reservationStatus { get; set; }
        public string guestRemarks { get; set; }
        public string managementRemarks { get; set; }
        public Nullable<int> shiftId { get; set; }
        public Nullable<int> counterId { get; set; }
        public Nullable<double> gross { get; set; }
        public Nullable<double> tax { get; set; }
        public Nullable<double> discount { get; set; }
        public Nullable<double> net { get; set; }
        public Nullable<double> advance { get; set; }
        public string reservedFor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationDetail> ReservationDetail { get; set; }
    }
}
