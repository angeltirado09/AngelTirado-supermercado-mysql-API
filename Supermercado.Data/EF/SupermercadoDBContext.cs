using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Supermercado.Data.EF;

public partial class SupermercadoDBContext : DbContext
{
    public SupermercadoDBContext(DbContextOptions<SupermercadoDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductosId).HasName("PRIMARY");

            entity.Property(e => e.CapacidadMg)
                .HasMaxLength(250)
                .HasColumnName("CapacidadMG");
            entity.Property(e => e.CapacidadMl)
                .HasMaxLength(250)
                .HasColumnName("CapacidadML");
            entity.Property(e => e.Categoria).HasMaxLength(250);
            entity.Property(e => e.Marca).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(250);
            entity.Property(e => e.Precio).HasMaxLength(250);
            entity.Property(e => e.Stock)
                .HasMaxLength(250)
                .HasDefaultValueSql("'0'");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
