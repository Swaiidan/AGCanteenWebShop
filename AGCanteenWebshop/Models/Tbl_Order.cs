
namespace AGCanteenWebshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Order()
        {
            this.Tbl_LunchOrderDetail = new HashSet<Tbl_LunchOrderDetail>();
            this.Tbl_OrderDetail = new HashSet<Tbl_OrderDetail>();
        }
    
        public int Fld_OrderID { get; set; }
        public Nullable<int> Fld_OrderWeekNumber { get; set; }
        public Nullable<System.DateTime> Fld_OrderDate { get; set; }
        public Nullable<int> Fld_OrderQuantity { get; set; }
        public Nullable<decimal> Fld_OrderTotalPrice { get; set; }
        public Nullable<int> Fld_CustomerID { get; set; }
    
        public virtual Tbl_Customer Tbl_Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_LunchOrderDetail> Tbl_LunchOrderDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_OrderDetail> Tbl_OrderDetail { get; set; }
    }
}
