//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Element
    {
        public int elementId { get; set; }
        public string elementRouting { get; set; }
        public string elementName { get; set; }
        public int typeId { get; set; }
    
        public virtual ElementsType ElementsType { get; set; }
    }
}
