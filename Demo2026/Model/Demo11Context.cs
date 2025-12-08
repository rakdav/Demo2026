using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Demo2026.Model;

public partial class Demo11Context : DbContext
{
    public Demo11Context()
    {
    }

    public Demo11Context(DbContextOptions<Demo11Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderPickupPoint> OrderPickupPoints { get; set; }

    public virtual DbSet<PickerItem> PickerItems { get; set; }

    public virtual DbSet<Pickup> Pickups { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=teacherpc;Initial Catalog=demo11;User ID=user11;Password=user11;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Articul).HasName("PK_Order");

            entity.Property(e => e.Articul).HasMaxLength(10);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Manufacture).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Photo).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Suplier).HasMaxLength(50);
            entity.Property(e => e.UnitMeasure).HasMaxLength(50);
        });

        modelBuilder.Entity<OrderPickupPoint>(entity =>
        {
            entity.ToTable("OrderPickupPoint");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PickerItem>(entity =>
        {
            entity.ToTable("Picker_item");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Articul)
                .HasMaxLength(10)
                .HasColumnName("articul");

            entity.HasOne(d => d.ArticulNavigation).WithMany(p => p.PickerItems)
                .HasForeignKey(d => d.Articul)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Picker_item_Orders");

            entity.HasOne(d => d.OrderNumberNavigation).WithMany(p => p.PickerItems)
                .HasForeignKey(d => d.OrderNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Picker_item_Pickup");
        });

        modelBuilder.Entity<Pickup>(entity =>
        {
            entity.ToTable("Pickup");

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.LoginNavigation).WithMany(p => p.Pickups)
                .HasForeignKey(d => d.Login)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pickup_Users");

            entity.HasOne(d => d.PointNavigation).WithMany(p => p.Pickups)
                .HasForeignKey(d => d.Point)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pickup_OrderPickupPoint");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Login).HasName("PK_users");

            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
