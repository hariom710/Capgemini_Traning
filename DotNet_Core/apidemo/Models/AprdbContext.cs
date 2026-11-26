using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace apidemo.Models;

public partial class AprdbContext : DbContext
{
    public AprdbContext()
    {
    }

    public AprdbContext(DbContextOptions<AprdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Location).HasMaxLength(25);
            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasIndex(e => e.DeptId, "IX_Emps_DeptId");

            entity.HasIndex(e => e.Email, "IX_Emps_EMail")
                .IsUnique()
                .HasFilter("([EMail] IS NOT NULL)");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMail");
            entity.Property(e => e.Name).HasMaxLength(30);

            entity.HasOne(d => d.Dept).WithMany(p => p.Emps).HasForeignKey(d => d.DeptId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
