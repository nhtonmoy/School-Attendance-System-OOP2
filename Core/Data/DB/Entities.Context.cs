﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<BaseData> BaseDatas { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassSection> ClassSections { get; set; }
        public DbSet<ClassSectionDayPeriodSubject> ClassSectionDayPeriodSubjects { get; set; }
        public DbSet<ClassSectionSubject> ClassSectionSubjects { get; set; }
        public DbSet<ClassSectionSubjectTeacher> ClassSectionSubjectTeachers { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PromotionHistory> PromotionHistories { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClassSection> StudentClassSections { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherExpertise> TeacherExpertises { get; set; }
        public DbSet<TempPromotionTable> TempPromotionTables { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
