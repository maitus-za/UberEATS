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
    
    public partial class tblPayment
    {
        public int payment_Id { get; set; }
        public string card_Name { get; set; }
        public string card_CCV { get; set; }
        public string card_ExpMonth { get; set; }
        public string card_ExpYear { get; set; }
        public Nullable<System.DateTime> payment_Date { get; set; }
        public int cust_Id { get; set; }
    }
}
