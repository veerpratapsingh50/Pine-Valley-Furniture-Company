//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G5_PVFAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.ORDER_LINE = new HashSet<ORDER_LINE>();
            this.WORK_CENTER = new HashSet<WORK_CENTER>();
        }
    
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFinish { get; set; }
        public decimal ProductStandardPrice { get; set; }
        public string ProductLineID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_LINE> ORDER_LINE { get; set; }
        public virtual PRODUCT_LINE PRODUCT_LINE { get; set; }
        public virtual USES USES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WORK_CENTER> WORK_CENTER { get; set; }
    }
}
