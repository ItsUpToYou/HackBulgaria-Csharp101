//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuthorsBook
    {
        public short AuthorBookId { get; set; }
        public short AuthorID { get; set; }
        public short BookId { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
