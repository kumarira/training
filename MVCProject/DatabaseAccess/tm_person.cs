//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tm_person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tm_person()
        {
            this.tm_tweets = new HashSet<tm_tweets>();
            this.tx_following = new HashSet<tx_following>();
            this.tx_following1 = new HashSet<tx_following>();
        }
    
        public string UserId { get; set; }
        public byte[] Password { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public System.DateTime Joined { get; set; }
        public bool active { get; set; }
        public Nullable<System.DateTime> deactivatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tm_tweets> tm_tweets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tx_following> tx_following { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tx_following> tx_following1 { get; set; }
    }
}
