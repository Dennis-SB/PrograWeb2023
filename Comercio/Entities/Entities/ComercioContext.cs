using System;
using System.Collections.Generic;
using Entities.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Entities
{
    public partial class ComercioContext : DbContext
    {
        public ComercioContext()
        {
            var optionBuilder = new DbContextOptionsBuilder<ComercioContext>();
            optionBuilder.UseSqlServer(Util.ConnectionString);
        }

        public ComercioContext(DbContextOptions<ComercioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; } = null!;
        public virtual DbSet<DetallePedido> DetallePedidos { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Pedido> Pedidos { get; set; } = null!;
        public virtual DbSet<Periodo> Periodos { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Util.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.HasKey(e => e.CodDetalleFactura);

                entity.ToTable("Detalle_Factura");

                entity.Property(e => e.CodDetalleFactura).HasColumnName("Cod_Detalle_Factura");

                entity.Property(e => e.CodProducto).HasColumnName("Cod_Producto");

                entity.Property(e => e.NumFactura).HasColumnName("Num_Factura");

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.NumFacturaNavigation)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.NumFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Detalle_Factura_Facturas");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasKey(e => e.CodDetallePedido);

                entity.ToTable("Detalle_Pedido");

                entity.Property(e => e.CodDetallePedido).HasColumnName("Cod_Detalle_Pedido");

                entity.Property(e => e.CodProducto).HasColumnName("Cod_Producto");

                entity.Property(e => e.NumPedido).HasColumnName("Num_Pedido");

                entity.HasOne(d => d.CodProductoNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.CodProducto)
                    .HasConstraintName("FK_Detalle_Pedido_Productos");

                entity.HasOne(d => d.NumPedidoNavigation)
                    .WithMany(p => p.DetallePedidos)
                    .HasForeignKey(d => d.NumPedido)
                    .HasConstraintName("FK_Detalle_Pedido_Pedidos");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.NumFactura);

                entity.Property(e => e.NumFactura)
                    .ValueGeneratedNever()
                    .HasColumnName("Num_Factura");

                entity.Property(e => e.Descuento).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Factura");

                entity.Property(e => e.Total).HasColumnType("decimal(15, 2)");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.NumPedido);

                entity.Property(e => e.NumPedido)
                    .ValueGeneratedNever()
                    .HasColumnName("Num_Pedido");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Pedido");

                entity.Property(e => e.MontoPedido)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("Monto_Pedido");

                entity.HasOne(d => d.CodProveedorNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.CodProveedor)
                    .HasConstraintName("FK_Pedidos_Proveedores");
            });

            modelBuilder.Entity<Periodo>(entity =>
            {
                entity.Property(e => e.FechaGeneracion).HasColumnType("date");

                entity.Property(e => e.FechaVencimiento).HasColumnType("date");

                entity.Property(e => e.Periodo1)
                    .HasMaxLength(10)
                    .HasColumnName("Periodo")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.CodProducto);

                entity.Property(e => e.CodProducto)
                    .ValueGeneratedNever()
                    .HasColumnName("Cod_Producto");

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Producto")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Precio).HasColumnType("decimal(12, 2)");

                entity.HasOne(d => d.CodProveedorNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.CodProveedor)
                    .HasConstraintName("FK_Productos_Proveedores");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.CodProveedor);

                entity.Property(e => e.CodProveedor).HasColumnName("Cod_Proveedor");

                entity.Property(e => e.CodigoArchivo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Proveedor")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasMany(d => d.UserUsers)
                    .WithMany(p => p.RoleRoles)
                    .UsingEntity<Dictionary<string, object>>(
                        "UsersInRole",
                        l => l.HasOne<User>().WithMany().HasForeignKey("UserUserId").HasConstraintName("FK_dbo.UserRoles_dbo.Users_User_UserId"),
                        r => r.HasOne<Role>().WithMany().HasForeignKey("RoleRoleId").HasConstraintName("FK_dbo.UserRoles_dbo.Roles_Role_RoleId"),
                        j =>
                        {
                            j.HasKey("RoleRoleId", "UserUserId").HasName("PK_dbo.RoleUsers");

                            j.ToTable("UsersInRoles");

                            j.IndexerProperty<int>("RoleRoleId").HasColumnName("Role_RoleId");

                            j.IndexerProperty<int>("UserUserId").HasColumnName("User_UserId");
                        });
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
