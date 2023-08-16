using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Entities
{
    public partial class UGymContext : DbContext
    {
        public UGymContext()
        {
        }

        public UGymContext(DbContextOptions<UGymContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administradore> Administradores { get; set; } = null!;
        public virtual DbSet<Asistencium> Asistencia { get; set; } = null!;
        public virtual DbSet<CodigoQr> CodigoQrs { get; set; } = null!;
        public virtual DbSet<ContactoEmergencium> ContactoEmergencia { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Expediente> Expedientes { get; set; } = null!;
        public virtual DbSet<InformesEvaluacion> InformesEvaluacions { get; set; } = null!;
        public virtual DbSet<InformesInbody> InformesInbodies { get; set; } = null!;
        public virtual DbSet<InformesTerapium> InformesTerapia { get; set; } = null!;
        public virtual DbSet<PlanAlimentacion> PlanAlimentacions { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Socio> Socios { get; set; } = null!;
        public virtual DbSet<SociosTipoMembresia> SociosTipoMembresias { get; set; } = null!;
        public virtual DbSet<SociosTipoPago> SociosTipoPagos { get; set; } = null!;
        public virtual DbSet<TipoMembresia> TipoMembresias { get; set; } = null!;
        public virtual DbSet<TipoPago> TipoPagos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=UGym;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administradore>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__Administ__719FE48800AC8258");

                entity.Property(e => e.CorreoElectronico).HasMaxLength(100);

                entity.Property(e => e.NombreCompleto).HasMaxLength(100);
            });

            modelBuilder.Entity<Asistencium>(entity =>
            {
                entity.HasKey(e => e.AsistenciaId)
                    .HasName("PK__Asistenc__72710FA5825D0352");

                entity.Property(e => e.FechaAsistencia).HasColumnType("date");
            });

            modelBuilder.Entity<CodigoQr>(entity =>
            {
                entity.ToTable("CodigoQR");

                entity.Property(e => e.CodigoQrid).HasColumnName("CodigoQRId");

                entity.Property(e => e.EnlaceQr)
                    .HasMaxLength(500)
                    .HasColumnName("EnlaceQR");
            });

            modelBuilder.Entity<ContactoEmergencium>(entity =>
            {
                entity.HasKey(e => e.ContactoEmergenciaId)
                    .HasName("PK__Contacto__9FF076ACA2E2B55F");

                entity.Property(e => e.NombreCompleto).HasMaxLength(100);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.Contraseña).HasMaxLength(500);

                entity.Property(e => e.CorreoElectronico).HasMaxLength(100);

                entity.Property(e => e.Direccion).HasMaxLength(150);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Genero).HasMaxLength(15);

                entity.Property(e => e.NombreCompleto).HasMaxLength(150);
            });

            modelBuilder.Entity<Expediente>(entity =>
            {
                entity.ToTable("Expediente");

                entity.Property(e => e.AlimentacionEstres).HasMaxLength(25);

                entity.Property(e => e.AutoRegulacion).HasMaxLength(50);

                entity.Property(e => e.CirugiasDetalle).HasMaxLength(100);

                entity.Property(e => e.CirugiasTipo).HasMaxLength(100);

                entity.Property(e => e.DificuladPerderGrasa).HasMaxLength(50);

                entity.Property(e => e.DoloresPecho).HasMaxLength(50);

                entity.Property(e => e.EjercicioTresMeses).HasMaxLength(5);

                entity.Property(e => e.EnfermedadCardiaca).HasMaxLength(100);

                entity.Property(e => e.FarmacosAlergia).HasMaxLength(100);

                entity.Property(e => e.FarmacosTipo).HasMaxLength(100);

                entity.Property(e => e.MotivoAsistencia).HasMaxLength(20);

                entity.Property(e => e.NivelEnergiaUltimoMes).HasMaxLength(50);
            });

            modelBuilder.Entity<InformesEvaluacion>(entity =>
            {
                entity.HasKey(e => e.InformeEvaluacionId)
                    .HasName("PK__Informes__65129BFF0B990D7F");

                entity.ToTable("InformesEvaluacion");

                entity.Property(e => e.EnlaceInformeEvaluacion).HasMaxLength(500);

                entity.Property(e => e.FechaCarga).HasColumnType("date");
            });

            modelBuilder.Entity<InformesInbody>(entity =>
            {
                entity.HasKey(e => e.InformeInbodyId)
                    .HasName("PK__Informes__BE1896F2F45A21BD");

                entity.ToTable("InformesInbody");

                entity.Property(e => e.EnlaceInformeInbody).HasMaxLength(500);

                entity.Property(e => e.FechaCarga).HasColumnType("date");
            });

            modelBuilder.Entity<InformesTerapium>(entity =>
            {
                entity.HasKey(e => e.InformeTerapiaId)
                    .HasName("PK__Informes__5801FE26B712B2D5");

                entity.Property(e => e.EnlaceInformeTerapia).HasMaxLength(500);

                entity.Property(e => e.FechaCarga).HasColumnType("date");
            });

            modelBuilder.Entity<PlanAlimentacion>(entity =>
            {
                entity.HasKey(e => e.PlanAlimenticioId)
                    .HasName("PK__PlanAlim__D2202E8F03FC16FB");

                entity.ToTable("PlanAlimentacion");

                entity.Property(e => e.FechaCarga).HasColumnType("date");

                entity.Property(e => e.PlanAlimenticio).HasMaxLength(500);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RolesId)
                    .HasName("PK__Roles__C4B27840A91ADDDD");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Socio>(entity =>
            {
                entity.Property(e => e.CodigoQrid).HasColumnName("CodigoQRId");

                entity.Property(e => e.ConoceGym).HasMaxLength(150);

                entity.Property(e => e.Contraseña).HasMaxLength(500);

                entity.Property(e => e.CorreoElectronico).HasMaxLength(150);

                entity.Property(e => e.Direccion).HasMaxLength(250);

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Genero).HasMaxLength(15);

                entity.Property(e => e.Motivacion).HasMaxLength(250);

                entity.Property(e => e.NombreCompleto).HasMaxLength(250);

                entity.Property(e => e.Ocupacion).HasMaxLength(100);

                entity.Property(e => e.Telefono).HasMaxLength(15);
            });

            modelBuilder.Entity<SociosTipoMembresia>(entity =>
            {
                entity.HasKey(e => new { e.SocioId, e.TipoMembresiaId })
                    .HasName("PK__SociosTi__54ED46BB62281370");

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.FechaExpiracion).HasColumnType("date");

                entity.Property(e => e.FechaInicio).HasColumnType("date");
            });

            modelBuilder.Entity<SociosTipoPago>(entity =>
            {
                entity.HasKey(e => new { e.SocioId, e.PagoId })
                    .HasName("PK__SociosTi__895DBEA99574D14D");

                entity.Property(e => e.FechaPago).HasColumnType("date");
            });

            modelBuilder.Entity<TipoMembresia>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Tipo).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.PagoId)
                    .HasName("PK__TipoPago__F00B613896DAD0CC");

                entity.Property(e => e.Monto).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Nombre).HasMaxLength(25);

                entity.Property(e => e.Tipo).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
