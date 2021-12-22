
namespace AGCanteenWebshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_ProductCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_ProductCategory()
        {
            this.Tbl_Product = new HashSet<Tbl_Product>();
        }
    
        public int Fld_ProductCategoryID { get; set; }
        public string Fld_ProductCategoryName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Product> Tbl_Product { get; set; }
    }
}
