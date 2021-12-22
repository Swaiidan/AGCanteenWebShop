
namespace AGCanteenWebshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Customer()
        {
            this.Tbl_Order = new HashSet<Tbl_Order>();
        }
    
        public int Fld_CustomerID { get; set; }
        public string Fld_CustomerName { get; set; }
        public Nullable<int> Fld_CustomerPhoneNumber { get; set; }
        public string Fld_CustomerEmail { get; set; }
        public string Fld_CustomerPassword { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Order> Tbl_Order { get; set; }
    }
}
