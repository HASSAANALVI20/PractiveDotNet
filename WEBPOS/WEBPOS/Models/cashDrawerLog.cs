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
    
    public partial class cashDrawerLog
    {
        public int logId { get; set; }
        public string userId { get; set; }
        public string shiftId { get; set; }
        public int tiltId { get; set; }
        public int counterId { get; set; }
        public System.DateTime date { get; set; }
        public string time { get; set; }
    }
}
