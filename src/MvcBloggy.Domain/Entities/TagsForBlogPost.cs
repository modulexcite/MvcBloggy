//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBloggy.Domain.Entities
{
    using GenericRepository;
    using System;
    using System.Collections.Generic;
    
    public partial class TagsForBlogPost : IEntity<Guid>
    {
        public System.Guid Id { get; set; }
        public System.Guid BlogPostId { get; set; }
        public System.Guid TagId { get; set; }
    
        public virtual BlogPost BlogPost { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
