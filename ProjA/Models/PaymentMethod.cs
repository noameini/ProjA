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
    
    public partial class PaymentMethod
    {
        public int CreditCardNumber { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public string company { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public int id { get; set; }
    
        public virtual Users Users { get; set; }
    }
}