//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace MvcBloggy.Data.DataAccess.SqlServer
{
    public partial class DynamicPage
    {
        public int DynamicPageId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string BriefInfo { get; set; }
        public string Content { get; set; }
        public bool IsApproved { get; set; }
        public Nullable<System.DateTimeOffset> CreatedOn { get; set; }
        public Nullable<System.DateTimeOffset> LastUpdatedOn { get; set; }
    
        public virtual Language Language { get; set; }
    }
    
}
