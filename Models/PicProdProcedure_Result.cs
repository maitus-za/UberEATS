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
    
    public partial class PicProdProcedure_Result
    {
        public int img_Id { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> produ_Id { get; set; }
        public int prod_Id { get; set; }
        public string prod_Name { get; set; }
        public decimal prod_Price { get; set; }
        public string prod_Type { get; set; }
        public string prod_Description { get; set; }
    }
}
