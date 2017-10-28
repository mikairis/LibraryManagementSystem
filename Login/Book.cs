//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.IssueTrans = new HashSet<IssueTran>();
        }
    
        public int BookCode { get; set; }
        public string BookTitle { get; set; }
        public string BookCategory { get; set; }
        public string Rating { get; set; }
        public string Location { get; set; }
        public Nullable<int> AuthorID { get; set; }
        public Nullable<int> PublisherID { get; set; }
        public Nullable<int> CountryCode { get; set; }
        public Nullable<int> TotalStock { get; set; }
        public Nullable<int> NumberAvaliable { get; set; }
        public Nullable<int> NumberRented { get; set; }
    
        public virtual Author Author { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueTran> IssueTrans { get; set; }
    }
}
