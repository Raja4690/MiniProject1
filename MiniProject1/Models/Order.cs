//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniProject1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public string OrderNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public decimal FinalTotal { get; set; }
    }
}
