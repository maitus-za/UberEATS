//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UberEATS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrder
    {
        public int order_Id { get; set; }
        public decimal totalPrice { get; set; }
        public string order_DeliveryAddress { get; set; }
        public int cust_Id { get; set; }
        public string order_Status { get; set; }
        public string order_DeliveryStatus { get; set; }
    }
}
