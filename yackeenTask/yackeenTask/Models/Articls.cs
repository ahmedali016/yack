//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace yackeenTask.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Articls()
        {
            this.VisitorComments = new HashSet<VisitorComments>();
        }
    
        public int Id { get; set; }
        public int categoryId { get; set; }
        public string subject { get; set; }
        public string articleDetails { get; set; }
        public System.DateTime articleDate { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitorComments> VisitorComments { get; set; }
    }
}
