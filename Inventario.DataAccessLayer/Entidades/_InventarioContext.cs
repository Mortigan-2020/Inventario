using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Inventario.DataAccessLayer.Entidades
{
    public partial class _InventarioContext : DbContext
    {
        public _InventarioContext()
        {
        }

        public _InventarioContext(DbContextOptions<_InventarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<ProductosXTiendas> ProductosXTiendas { get; set; }
        public virtual DbSet<Tiendas> Tiendas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ASPIRE\\SQLSAGE50;Database=_Inventario;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.ToTable("productos");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            modelBuilder.Entity<ProductosXTiendas>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Productos_X_Tiendas");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.Property(e => e.IdTienda).HasColumnName("idTienda");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Productos_X_Tiendas_productos");

                entity.HasOne(d => d.IdTiendaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Productos_X_Tiendas_Tiendas");
            });

            modelBuilder.Entity<Tiendas>(entity =>
            {
                entity.HasKey(e => e.IdTienda);

                entity.Property(e => e.IdTienda).HasColumnName("idTienda");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
