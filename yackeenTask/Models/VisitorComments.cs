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
    
    public partial class VisitorComments
    {
        public int Id { get; set; }
        public int articleId { get; set; }
        public string visitorName { get; set; }
        public string comment { get; set; }
        public System.DateTime commentDate { get; set; }
    
        public virtual Articls Articls { get; set; }
    }
}