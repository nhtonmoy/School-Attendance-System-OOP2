//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Data.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Class
    {
        public Class()
        {
            this.ClassSections = new HashSet<ClassSection>();
            this.PromotionHistories = new HashSet<PromotionHistory>();
            this.PromotionHistories1 = new HashSet<PromotionHistory>();
            this.TempPromotionTables = new HashSet<TempPromotionTable>();
        }
    
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public bool IsGroup { get; set; }
        public bool IsActive { get; set; }
        public int OrderBy { get; set; }
    
        public virtual ICollection<ClassSection> ClassSections { get; set; }
        public virtual ICollection<PromotionHistory> PromotionHistories { get; set; }
        public virtual ICollection<PromotionHistory> PromotionHistories1 { get; set; }
        public virtual ICollection<TempPromotionTable> TempPromotionTables { get; set; }
    }
}
