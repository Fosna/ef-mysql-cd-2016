﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfQueries
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolEntities : DbContext
    {
        public SchoolEntities()
            : base("name=SchoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<standard> standard { get; set; }
        public virtual DbSet<studentaddress> studentaddress { get; set; }
        public virtual DbSet<teacher> teacher { get; set; }
        public virtual DbSet<course> course { get; set; }
        public virtual DbSet<student> student { get; set; }
        public virtual DbSet<studentcourse> studentcourse { get; set; }
    }
}
