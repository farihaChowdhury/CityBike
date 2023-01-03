using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CityBike.Data;

public partial class CityBikeContext : DbContext
{
    public CityBikeContext()
    {
    }

    public CityBikeContext(DbContextOptions<CityBikeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BikeStation> BikeStations { get; set; }

    public virtual DbSet<Journey> Journeys { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CityBike;Trusted_Connection=True;; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BikeStation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FID");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Kapasiteet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kaupunki)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Namn)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nimi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Operaattor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Osoite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.X)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("x");
            entity.Property(e => e.Y)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("y");
        });

        modelBuilder.Entity<Journey>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DepartureDate).HasColumnType("datetime");
            entity.Property(e => e.DepartureStationName).IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnStationName).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
