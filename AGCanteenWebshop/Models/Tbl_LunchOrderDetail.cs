
namespace AGCanteenWebshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_LunchOrderDetail
    {
        public int Fld_LunchOrderDetailID { get; set; }
        public Nullable<System.DateTime> Fld_LucnchOrderDetailDate { get; set; }
        public Nullable<int> Fld_LunchOrderDetailWeekNumber { get; set; }
        public string Fld_LunchOrderDetailProductName { get; set; }
        public Nullable<int> Fld_LunchOrderDetailProductQuantity { get; set; }
        public Nullable<decimal> Fld_LunchOrderDetailProductPrice { get; set; }
        public Nullable<int> Fld_LunchID { get; set; }
        public Nullable<int> Fld_OrderID { get; set; }
    
        public virtual Tbl_Lunch Tbl_Lunch { get; set; }
        public virtual Tbl_Order Tbl_Order { get; set; }
    }
}
