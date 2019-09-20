using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SGIAMT.Models
{
    public partial class BD_SGIAMTContext : DbContext
    {
        public BD_SGIAMTContext()
        {
        }

        public BD_SGIAMTContext(DbContextOptions<BD_SGIAMTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ECategoría> ECategoría { get; set; }
        public virtual DbSet<EDistrito> EDistrito { get; set; }
        public virtual DbSet<ENivel> ENivel { get; set; }
        public virtual DbSet<ENivelxTipoNivel> ENivelxTipoNivel { get; set; }
        public virtual DbSet<ETipoNivel> ETipoNivel { get; set; }
        public virtual DbSet<ETipoUsuario> ETipoUsuario { get; set; }
        public virtual DbSet<EUsuario> EUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ADMINISTRADOR\\ALONSO;Database=BD_SGIAMT;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ECategoría>(entity =>
            {
                entity.HasKey(e => e.PkIcId);

                entity.ToTable("E_Categoría");

                entity.Property(e => e.PkIcId)
                    .HasColumnName("PK_IC_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.VcNombreCat)
                    .IsRequired()
                    .HasColumnName("VC_NombreCat")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EDistrito>(entity =>
            {
                entity.HasKey(e => e.PkIdiCod);

                entity.ToTable("E_Distrito");

                entity.Property(e => e.PkIdiCod)
                    .HasColumnName("PK_IDI_Cod")
                    .ValueGeneratedNever();

                entity.Property(e => e.VdiNombreDis)
                    .IsRequired()
                    .HasColumnName("VDI_NombreDis")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ENivel>(entity =>
            {
                entity.HasKey(e => e.PkInCod);

                entity.ToTable("E_Nivel");

                entity.Property(e => e.PkInCod)
                    .HasColumnName("PK_IN_Cod")
                    .ValueGeneratedNever();

                entity.Property(e => e.VnNombreNivel)
                    .IsRequired()
                    .HasColumnName("VN_NombreNivel")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ENivelxTipoNivel>(entity =>
            {
                entity.HasKey(e => e.PkIntnCod);

                entity.ToTable("E_NivelxTipoNivel");

                entity.Property(e => e.PkIntnCod)
                    .HasColumnName("PK_INTN_Cod")
                    .ValueGeneratedNever();

                entity.Property(e => e.NroAlumno).HasColumnName("Nro_Alumno");

                entity.Property(e => e.PkInCod).HasColumnName("PK_IN_Cod");

                entity.Property(e => e.PkItnCod).HasColumnName("PK_ITN_Cod");

                entity.Property(e => e.PkIuDni).HasColumnName("PK_IU_Dni");

                entity.HasOne(d => d.PkInCodNavigation)
                    .WithMany(p => p.ENivelxTipoNivel)
                    .HasForeignKey(d => d.PkInCod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_E_NivelxTipoNivel8");

                entity.HasOne(d => d.PkItnCodNavigation)
                    .WithMany(p => p.ENivelxTipoNivel)
                    .HasForeignKey(d => d.PkItnCod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_E_NivelxTipoNivel7");

                entity.HasOne(d => d.PkIuDniNavigation)
                    .WithMany(p => p.ENivelxTipoNivel)
                    .HasForeignKey(d => d.PkIuDni)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_E_NivelxTipoNivel_E_Usuario");
            });

            modelBuilder.Entity<ETipoNivel>(entity =>
            {
                entity.HasKey(e => e.PkItnCod);

                entity.ToTable("E_TipoNivel");

                entity.Property(e => e.PkItnCod)
                    .HasColumnName("PK_ITN_Cod")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItnNombreTipoNivel)
                    .IsRequired()
                    .HasColumnName("ITN_NombreTipoNivel")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ETipoUsuario>(entity =>
            {
                entity.HasKey(e => e.PkItuTipoUsuario);

                entity.ToTable("E_TipoUsuario");

                entity.Property(e => e.PkItuTipoUsuario)
                    .HasColumnName("PK_ITU_TipoUsuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.VtuNombreTipoUsuario)
                    .IsRequired()
                    .HasColumnName("VTU_NombreTipoUsuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EUsuario>(entity =>
            {
                entity.HasKey(e => e.PkIuDni);

                entity.ToTable("E_Usuario");

                entity.Property(e => e.PkIuDni)
                    .HasColumnName("PK_IU_Dni")
                    .ValueGeneratedNever();

                entity.Property(e => e.DuFechaNacimiento)
                    .HasColumnName("DU_FechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.PkIcId).HasColumnName("PK_IC_Id");

                entity.Property(e => e.PkIdiCod).HasColumnName("PK_IDI_Cod");

                entity.Property(e => e.PkItuTipoUsuario).HasColumnName("PK_ITU_TipoUsuario");

                entity.Property(e => e.VuAmaterno)
                    .IsRequired()
                    .HasColumnName("VU_AMaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuApaterno)
                    .IsRequired()
                    .HasColumnName("VU_APaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuCelular).HasColumnName("VU_Celular");

                entity.Property(e => e.VuContraseña)
                    .IsRequired()
                    .HasColumnName("VU_Contraseña")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuCorreo)
                    .IsRequired()
                    .HasColumnName("VU_Correo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuDireccion)
                    .IsRequired()
                    .HasColumnName("VU_Direccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuEstado)
                    .IsRequired()
                    .HasColumnName("VU_Estado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuHorario)
                    .IsRequired()
                    .HasColumnName("VU_Horario")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuNombre)
                    .IsRequired()
                    .HasColumnName("VU_Nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VuSexo)
                    .IsRequired()
                    .HasColumnName("VU_Sexo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PkIc)
                    .WithMany(p => p.EUsuario)
                    .HasForeignKey(d => d.PkIcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_E_Usuario2");

                entity.HasOne(d => d.PkIdiCodNavigation)
                    .WithMany(p => p.EUsuario)
                    .HasForeignKey(d => d.PkIdiCod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_E_Usuario_E_Distrito");

                entity.HasOne(d => d.PkItuTipoUsuarioNavigation)
                    .WithMany(p => p.EUsuario)
                    .HasForeignKey(d => d.PkItuTipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_E_Usuario0");
            });
        }
    }
}
