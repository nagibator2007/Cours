﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarServiceWpfApp.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ServiceDB : DbContext
    {
        public ServiceDB()
            : base("name=ServiceDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CarInfo> CarInfo { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Profession> Profession { get; set; }
        public virtual DbSet<Regestration> Regestration { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServicesInfo> ServicesInfo { get; set; }
        public virtual DbSet<Spare> Spare { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}