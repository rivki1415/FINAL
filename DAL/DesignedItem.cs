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
    
    public partial class DesignedItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DesignedItem()
        {
            this.OrdersDetails = new HashSet<OrdersDetail>();
        }
    
        public int designedItemId { get; set; }
        public int sheetTypeId { get; set; }
        public string routingToJsonFile { get; set; }
        public string routingToJpegFile { get; set; }
        public Nullable<int> coverId { get; set; }
        public bool isSaved { get; set; }
    
        public virtual Cover Cover { get; set; }
        public virtual SheetsType SheetsType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}
