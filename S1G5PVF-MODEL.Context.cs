﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class S1G5_PVFDBEntities2 : DbContext
    {
        public S1G5_PVFDBEntities2()
            : base("name=S1G5_PVFDBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEE { get; set; }
        public virtual DbSet<ORDER> ORDER { get; set; }
        public virtual DbSet<ORDER_LINE> ORDER_LINE { get; set; }
        public virtual DbSet<PRODUCT> PRODUCT { get; set; }
        public virtual DbSet<PRODUCT_LINE> PRODUCT_LINE { get; set; }
        public virtual DbSet<RAW_MATERIAL> RAW_MATERIAL { get; set; }
        public virtual DbSet<SALESPERSON> SALESPERSON { get; set; }
        public virtual DbSet<SKILL> SKILL { get; set; }
        public virtual DbSet<SUPPLIES> SUPPLIES { get; set; }
        public virtual DbSet<TERRITORY> TERRITORY { get; set; }
        public virtual DbSet<USES> USES { get; set; }
        public virtual DbSet<VENDOR> VENDOR { get; set; }
        public virtual DbSet<WORK_CENTER> WORK_CENTER { get; set; }
    }
}
