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
    
    public partial class Person
    {
        public Person()
        {
            this.Employees = new HashSet<Employee>();
            this.Students = new HashSet<Student>();
        }
    
        public int PersonId { get; set; }
        public string Name { get; set; }
        public System.DateTime BirthDate { get; set; }
        public Nullable<int> BloodGroupId { get; set; }
        public int GenderId { get; set; }
        public string Religion { get; set; }
        public string Address { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual BaseData BaseData { get; set; }
        public virtual BaseData BaseData1 { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
