//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int dealNumber { get; set; }
        public string seller { get; set; }
        public string buyer { get; set; }
        public int itemNumber { get; set; }
        public string manufacturerName { get; set; }
        public string modelName { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual itemNumber itemNumber1 { get; set; }
        public virtual manufacturer manufacturer { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}
