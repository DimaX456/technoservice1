using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TecnoService.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TecnoService.Context
{
    public partial class TechnoserviceContext : DbContext
    {
        public TechnoserviceContext()
        {
        }

        public TechnoserviceContext(DbContextOptions<TechnoserviceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<EquipmentTypes> EquipmentTypes { get; set; }
        public virtual DbSet<Malfunctions> Malfunctions { get; set; }
        public virtual DbSet<Processing> Processing { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-T9MJ8MA\\SQLEXPRESS; DataBase=Technoservice;Integrated Security=false; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_Comments_Requests");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.Staffid)
                    .HasConstraintName("FK_Comments_Staff");
            });

            modelBuilder.Entity<EquipmentTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Malfunctions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Processing>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Requst)
                    .WithMany(p => p.Processing)
                    .HasForeignKey(d => d.RequstId)
                    .HasConstraintName("FK_Processing_Requests");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Processing)
                    .HasForeignKey(d => d.Staffid)
                    .HasConstraintName("FK_Processing_Staff");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Malfunctions)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.Malfunctionsid)
                    .HasConstraintName("FK_Reports_Malfunctions");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_Reports_Requests");
            });

            modelBuilder.Entity<Requests>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Requests_Users");

                entity.HasOne(d => d.EqupmentType)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.EqupmentTypeId)
                    .HasConstraintName("FK_Requests_EquipmentTypes");

                entity.HasOne(d => d.Malfunction)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.MalfunctionId)
                    .HasConstraintName("FK_Requests_Malfunctions");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_Service_Requests");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e=>e.Name)
                .HasMaxLength(50)
                .IsUnicode (false); 
               
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
