//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBloggy.Data.DataAccess.SqlServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class RestrictedPageName
    {
        public int RestrictedPageNameID { get; set; }
        public int LanguageID { get; set; }
        public System.Guid RestrictedPageNameGUID { get; set; }
        public string RestrictedPageTerm { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual Language Language { get; set; }
    }
}