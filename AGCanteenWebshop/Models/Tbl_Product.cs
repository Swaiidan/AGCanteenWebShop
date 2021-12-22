
namespace AGCanteenWebshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Product()
        {
            this.Tbl_OrderDetail = new HashSet<Tbl_OrderDetail>();
        }
    
        public int Fld_ProductID { get; set; }
        public string Fld_ProductName { get; set; }
        public Nullable<decimal> Fld_ProductPrice { get; set; }
        public string Fld_ProductDescription { get; set; }
        public Nullable<int> Fld_ProductCategoryID { get; set; }
        public string Fld_ProductImagePath { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_OrderDetail> Tbl_OrderDetail { get; set; }
        public virtual Tbl_ProductCategory Tbl_ProductCategory { get; set; }
    }
}
