//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AGCanteenWebshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_CustomerRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_CustomerRole()
        {
            this.Tbl_Customer = new HashSet<Tbl_Customer>();
        }
    
        public int Fld_RoleId { get; set; }
        public string Fld_RoleName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Customer> Tbl_Customer { get; set; }
        public virtual Tbl_CustomerRole Tbl_CustomerRole1 { get; set; }
        public virtual Tbl_CustomerRole Tbl_CustomerRole2 { get; set; }
    }
}
