
namespace AGCanteenWebshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Lunch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Lunch()
        {
            this.Tbl_LunchOrderDetail = new HashSet<Tbl_LunchOrderDetail>();
        }
    
        public int Fld_LunchID { get; set; }
        public string Fld_LunchName { get; set; }
        public Nullable<decimal> Fld_LunchPrice { get; set; }
        public string Fld_LunchDescription { get; set; }
        public Nullable<System.DateTime> Fld_LunchDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_LunchOrderDetail> Tbl_LunchOrderDetail { get; set; }
    }
}
