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
    
    public partial class addCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public addCategory()
        {
            this.addItem = new HashSet<addItem>();
        }
    
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public Nullable<int> departmentId { get; set; }
        public Nullable<bool> categoryActive { get; set; }
        public Nullable<System.DateTime> addedDate { get; set; }
        public string categoryType { get; set; }
        public string colorCode { get; set; }
        public Nullable<int> categorySequence { get; set; }
        public Nullable<bool> toppingCategory { get; set; }
    
        public virtual addDepartment addDepartment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<addItem> addItem { get; set; }
    }
}
