
namespace AGCanteenWebshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_OrderDetail
    {
        public int Fld_OrderDetailID { get; set; }
        public Nullable<System.DateTime> Fld_OrderDetailDate { get; set; }
        public Nullable<int> Fld_OrderDetailWeekNumber { get; set; }
        public string Fld_OrderDetailProductName { get; set; }
        public Nullable<int> Fld_OrderDetailProductQuantity { get; set; }
        public Nullable<decimal> Fld_OrderDetailProductPrice { get; set; }
        public Nullable<int> Fld_ProductID { get; set; }
        public Nullable<int> Fld_OrderID { get; set; }
    
        public virtual Tbl_Order Tbl_Order { get; set; }
        public virtual Tbl_Product Tbl_Product { get; set; }
    }
}
