//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Predavanje6___EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drzave
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drzave()
        {
            this.Slucajevi = new HashSet<Slucajevi>();
        }
    
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Kratica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slucajevi> Slucajevi { get; set; }
    }
}
