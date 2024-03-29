﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SGIAMT.Models
{
    public partial class BD_SGIAMTvscus1cu2Context : DbContext
    {
        public BD_SGIAMTvscus1cu2Context()
        {
        }

        public BD_SGIAMTvscus1cu2Context(DbContextOptions<BD_SGIAMTvscus1cu2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TCategoría> TCategoría { get; set; }
        public virtual DbSet<TConceptoPago> TConceptoPago { get; set; }
        public virtual DbSet<TDistrito> TDistrito { get; set; }
        public virtual DbSet<TNivel> TNivel { get; set; }
        public virtual DbSet<TNivelxTipoNivel> TNivelxTipoNivel { get; set; }
        public virtual DbSet<TPago> TPago { get; set; }
        public virtual DbSet<TTipoNivel> TTipoNivel { get; set; }
        public virtual DbSet<TTipoUsuario> TTipoUsuario { get; set; }
        public virtual DbSet<TUsuario> TUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ADMINISTRADOR\\ALONSO;Database=BD_SGIAMTvscus1cu2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCategoría>(entity =>
            {
                entity.HasKey(e => e.PkIcId);

                entity.ToTable("T_Categoría");

                entity.Property(e => e.PkIcId)
                    .HasColumnName("PK_IC_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.VcNombreCat)
                    .IsRequired()
                    .HasColumnName("VC_NombreCat")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TConceptoPago>(entity =>
            {
                entity.HasKey(e => e.PkIcpId);

                entity.ToTable("T_Concepto_Pago");

                entity.Property(e => e.PkIcpId).HasColumnName("PK_ICP_Id");

                entity.Property(e => e.VcpDescripcion)
                    .HasColumnName("VCP_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VcpValor)
                    .HasColumnName("VCP_Valor")
                    .HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<TDistrito>(entity =>
            {
                entity.HasKey(e => e.PkIdiCod);

                entity.ToTable("T_Distrito");

                entity.Property(e => e.PkIdiCod)
                    .HasColumnName("PK_IDI_Cod")
                    .ValueGeneratedNever();

                entity.Property(e => e.VdiNombreDis)
                    .IsRequired()
                    .HasColumnName("VDI_NombreDis")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TNivel>(entity =>
            {
                entity.HasKey(e => e.PkInCod);

                entity.ToTable("T_Nivel");

                entity.Property(e => e.PkInCod)
                    .HasColumnName("PK_IN_Cod")
                    .ValueGeneratedNever();

                entity.Property(e => e.VnNombreNivel)
                    .IsRequired()
                    .HasColumnName("VN_NombreNivel")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TNivelxTipoNivel>(entity =>
            {
                entity.HasKey(e => e.PkIntnCod);

                entity.ToTable("T_NivelxTipoNivel");

                entity.Property(e => e.PkIntnCod).HasColumnName("PK_INTN_Cod");

                entity.Property(e => e.FkInCod).HasColumnName("FK_IN_Cod");

                entity.Property(e => e.FkItnCod).HasColumnName("FK_ITN_Cod");

                entity.Property(e => e.FkIuDni).HasColumnName("FK_IU_Dni");

                entity.Property(e => e.NroAlumno).HasColumnName("Nro_Alumno");

                entity.HasOne(d => d.FkInCodNavigation)
                    .WithMany(p => p.TNivelxTipoNivel)
                    .HasForeignKey(d => d.FkInCod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_E_NivelxTipoNivel8");

                entity.HasOne(d => d.FkItnCodNavigation)
                    .WithMany(p => p.TNivelxTipoNivel)
                    .HasForeignKey(d => d.FkItnCod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_E_NivelxTipoNivel7");

                entity.HasOne(d => d.FkIuDniNavigation)
                    .WithMany(p => p.TNivelxTipoNivel)
                    .HasForeignKey(d => d.FkIuDni)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_E_NivelxTipoNivel_E_Usuario");
            });

            modelBuilder.Entity<TPago>(entity =>
            {
                entity.HasKey(e => e.PkIpId);

                entity.ToTable("T_Pago");

                entity.Property(e => e.PkIpId).HasColumnName("PK_IP_Id");

                entity.Property(e => e.FkIcpId).HasColumnName("FK_ICP_Id");

                entity.Property(e => e.FkIuDni).HasColumnName("FK_IU_Dni");

                entity.Property(e => e.VpAño).HasColumnName("VP_Año");

                entity.Property(e => e.VpFecha)
                    .HasColumnName("VP_Fecha")
                    .HasColumnType("date");

                entity.Property(e => e.VpMes)
                    .HasColumnName("VP_Mes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VpPdf)
                    .HasColumnName("VP_Pdf")
                    .HasMaxLength(1);

                entity.Property(e => e.VpValor)
                    .HasColumnName("VP_Valor")
                    .HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.FkIcpNavigation)
                    .WithMany(p => p.TPago)
                    .HasForeignKey(d => d.FkIcpId)
                    .HasConstraintName("FK__T_Pago__FK_ICP_I__4F7CD00D");

                entity.HasOne(d => d.FkIuDniNavigation)
                    .WithMany(p => p.TPago)
                    .HasForeignKey(d => d.FkIuDni)
                    .HasConstraintName("FK__T_Pago__FK_IU_Dn__4E88ABD4");
            });

            modelBuilder.Entity<TTipoNivel>(entity =>
            {
                entity.HasKey(e => e.PkItnCod);

                entity.ToTable("T_TipoNivel");

                entity.Property(e => e.PkItnCod)
                    .HasColumnName("PK_ITN_Cod")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItnNombreTipoNivel)
                    .IsRequired()
                    .HasColumnName("ITN_NombreTipoNivel")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTipoUsuario>(entity =>
            {
                entity.HasKey(e => e.PkItuTipoUsuario);

                entity.ToTable("T_TipoUsuario");

                entity.Property(e => e.PkItuTipoUsuario)
                    .HasColumnName("PK_ITU_TipoUsuario")
                    .ValueGeneratedNever();

                entity.Property(e => e.VtuNombreTipoUsuario)
                    .IsRequired()
                    .HasColumnName("VTU_NombreTipoUsuario")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TUsuario>(entity =>
            {
                entity.HasKey(e => e.PkIuDni);

                entity.ToTable("T_Usuario");

                entity.Property(e => e.PkIuDni)
                    .HasColumnName("PK_IU_Dni")
                    .ValueGeneratedNever();

                entity.Property(e => e.DuFechaNacimiento)
                    .HasColumnName("DU_FechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.FkIcId).HasColumnName("FK_IC_Id");

                entity.Property(e => e.FkIdiCod).HasColumnName("FK_IDI_Cod");

                entity.Property(e => e.FkItuTipoUsuario).HasColumnName("FK_ITU_TipoUsuario");

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

                entity.HasOne(d => d.FkIcIdNavigation)
                    .WithMany(p => p.TUsuario)
                    .HasForeignKey(d => d.FkIcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_E_Usuario2");

                entity.HasOne(d => d.FkIdiCodNavigation)
                    .WithMany(p => p.TUsuario)
                    .HasForeignKey(d => d.FkIdiCod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_E_Usuario_E_Distrito");

                entity.HasOne(d => d.FkItuTipoUsuarioNavigation)
                    .WithMany(p => p.TUsuario)
                    .HasForeignKey(d => d.FkItuTipoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_E_Usuario0");
            });
        }
    }
}
