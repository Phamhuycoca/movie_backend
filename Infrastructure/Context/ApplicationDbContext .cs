using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .ToTable("Category")
            .HasMany(c => c.ChildrenCategories)
            .WithOne(c => c.ParentCategory)
            .HasForeignKey(c => c.CategoryChildrenId)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<Category>()
            .HasOne(c => c.ParentCategory)
            .WithMany(c => c.ChildrenCategories)
            .HasForeignKey(c => c.CategoryChildrenId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.Created = DateTime.Now;
                    entry.Entity.CreatedBy = null;
                    break;
                case EntityState.Modified:
                    entry.Entity.Updated = DateTime.Now;
                    entry.Entity.UpdatedBy = null;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}