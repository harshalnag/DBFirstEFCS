//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public Blog()
        {
            this.Posts = new HashSet<Post>();
        }
    
        // Primitive properties
    
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string BloggerName { get; set; }
    
        // Navigation properties
    
        public virtual ICollection<Post> Posts { get; set; }
    
    }
}
