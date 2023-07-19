using ABProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace ABProject.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class ABProjectDbContext : AbpDbContext<ABProjectDbContext>
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */
    public DbSet<ModelHu3> ModelHu3s { get; set; }

    public ABProjectDbContext(DbContextOptions<ABProjectDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(ABProjectConsts.DbTablePrefix + "YourEntities", ABProjectConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});

        builder.Entity<ModelHu3>(e =>
        {
            e.Property<Guid>("Id").ValueGeneratedOnAdd();
            e.HasKey("Id");
            e.ConfigureByConvention();
        });
    }
}
