using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ParkingManagement.Infrastracture.Entities;

#nullable disable

namespace ParkingManagement
{
    public partial class ParkingManegmentContext : DbContext
    {
        public ParkingManegmentContext()
        {
        }

        public ParkingManegmentContext(DbContextOptions<ParkingManegmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Parking> Parkings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=ParkingManegment;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("CId");

                entity.Property(e => e.CarNumber).HasMaxLength(50);

                entity.Property(e => e.Fromdate).HasColumnType("datetime");

                entity.Property(e => e.Todate).HasColumnType("datetime");

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_Cars_Parking");
            });

            modelBuilder.Entity<Parking>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("Parking");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("PId");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
