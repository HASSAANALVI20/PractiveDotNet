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
    
    public partial class cityArea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cityArea()
        {
            this.areaLandMark = new HashSet<areaLandMark>();
        }
    
        public int cityAreaId { get; set; }
        public string areaName { get; set; }
        public string areaPrefix { get; set; }
        public byte deliveryRestriction { get; set; }
        public int cityId { get; set; }
        public System.DateTime addedDate { get; set; }
        public Nullable<int> branchId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<areaLandMark> areaLandMark { get; set; }
        public virtual City City { get; set; }
    }
}
