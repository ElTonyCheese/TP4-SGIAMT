using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class ampkkmpfepk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Cliente_T_Rubro_idRubro",
                table: "T_Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cliente_T_Usuario_idUsuario",
                table: "T_Cliente");

            migrationBuilder.DropTable(
                name: "T_Horario");

            migrationBuilder.DropTable(
                name: "T_ClientexServicio");

            migrationBuilder.DropIndex(
                name: "IX_T_Cliente_idRubro",
                table: "T_Cliente");

            migrationBuilder.DropIndex(
                name: "IX_T_Cliente_idUsuario",
                table: "T_Cliente");

            migrationBuilder.DropColumn(
                name: "nombreServicio",
                table: "T_Solicitud");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "T_Cliente");

            migrationBuilder.DropColumn(
                name: "documento",
                table: "T_Cliente");

            migrationBuilder.RenameColumn(
                name: "pdfCotizar",
                table: "T_Cotizacion",
                newName: "nombrepdf");

            migrationBuilder.RenameColumn(
                name: "tipoEmpresa",
                table: "T_Cliente",
                newName: "T_UsuarioidUsuario");

            migrationBuilder.RenameColumn(
                name: "idRubro",
                table: "T_Cliente",
                newName: "ruc");

            migrationBuilder.RenameColumn(
                name: "Dni",
                table: "AspNetUsers",
                newName: "TipoDocumemnto");

            migrationBuilder.AddColumn<int>(
                name: "T_RolidRol",
                table: "T_Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "T_RubroidRubro",
                table: "T_Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "T_TipoDocumentoidDocumento",
                table: "T_Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idOrdenTrabajo",
                table: "T_Solicitud",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "T_Solicitud",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "razonSocial",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<int>(
                name: "idUsuario",
                table: "T_Cliente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "T_UsuarioidUsuario",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Documento",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "T_OrdenTrabajo",
                columns: table => new
                {
                    idOrdenTrabajo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    T_UsuarioidUsuario = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    idUsuario = table.Column<int>(nullable: false),
                    progreso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_OrdenTrabajo", x => x.idOrdenTrabajo);
                    table.ForeignKey(
                        name: "FK_T_OrdenTrabajo_T_Usuario_T_UsuarioidUsuario",
                        column: x => x.T_UsuarioidUsuario,
                        principalTable: "T_Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_Rol",
                columns: table => new
                {
                    idRol = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    detalleRol = table.Column<string>(nullable: true),
                    nombreRol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Rol", x => x.idRol);
                });

            migrationBuilder.CreateTable(
                name: "T_TipoDocumento",
                columns: table => new
                {
                    idDocumento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombreDoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TipoDocumento", x => x.idDocumento);
                });

            migrationBuilder.CreateTable(
                name: "T_Versionamiento",
                columns: table => new
                {
                    idVersion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    detalleRespuesta = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    fechaCreacion = table.Column<DateTime>(nullable: false),
                    fechaRespuesta = table.Column<DateTime>(nullable: false),
                    idCotizacion = table.Column<int>(nullable: false),
                    nombrepdf = table.Column<string>(nullable: true),
                    precio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Versionamiento", x => x.idVersion);
                    table.ForeignKey(
                        name: "FK_T_Versionamiento_T_Cotizacion_idCotizacion",
                        column: x => x.idCotizacion,
                        principalTable: "T_Cotizacion",
                        principalColumn: "idCotizacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Entregable",
                columns: table => new
                {
                    idEntregable = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    estado = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false),
                    fechaModificacion = table.Column<DateTime>(nullable: false),
                    horaFin = table.Column<string>(nullable: true),
                    horaInicio = table.Column<string>(nullable: true),
                    idOrdenTrabajo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Entregable", x => x.idEntregable);
                    table.ForeignKey(
                        name: "FK_T_Entregable_T_OrdenTrabajo_idOrdenTrabajo",
                        column: x => x.idOrdenTrabajo,
                        principalTable: "T_OrdenTrabajo",
                        principalColumn: "idOrdenTrabajo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_T_RolidRol",
                table: "T_Usuario",
                column: "T_RolidRol");

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_T_RubroidRubro",
                table: "T_Usuario",
                column: "T_RubroidRubro");

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_T_TipoDocumentoidDocumento",
                table: "T_Usuario",
                column: "T_TipoDocumentoidDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_T_Solicitud_idOrdenTrabajo",
                table: "T_Solicitud",
                column: "idOrdenTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_T_Solicitud_idServicio",
                table: "T_Solicitud",
                column: "idServicio");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cliente_T_UsuarioidUsuario",
                table: "T_Cliente",
                column: "T_UsuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_T_Entregable_idOrdenTrabajo",
                table: "T_Entregable",
                column: "idOrdenTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_T_OrdenTrabajo_T_UsuarioidUsuario",
                table: "T_OrdenTrabajo",
                column: "T_UsuarioidUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_T_Versionamiento_idCotizacion",
                table: "T_Versionamiento",
                column: "idCotizacion");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cliente_T_Usuario_T_UsuarioidUsuario",
                table: "T_Cliente",
                column: "T_UsuarioidUsuario",
                principalTable: "T_Usuario",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Solicitud_T_OrdenTrabajo_idOrdenTrabajo",
                table: "T_Solicitud",
                column: "idOrdenTrabajo",
                principalTable: "T_OrdenTrabajo",
                principalColumn: "idOrdenTrabajo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Solicitud_T_Servicio_idServicio",
                table: "T_Solicitud",
                column: "idServicio",
                principalTable: "T_Servicio",
                principalColumn: "idServicio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rol_T_RolidRol",
                table: "T_Usuario",
                column: "T_RolidRol",
                principalTable: "T_Rol",
                principalColumn: "idRol",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rubro_T_RubroidRubro",
                table: "T_Usuario",
                column: "T_RubroidRubro",
                principalTable: "T_Rubro",
                principalColumn: "idRubro",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_TipoDocumento_T_TipoDocumentoidDocumento",
                table: "T_Usuario",
                column: "T_TipoDocumentoidDocumento",
                principalTable: "T_TipoDocumento",
                principalColumn: "idDocumento",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Cliente_T_Usuario_T_UsuarioidUsuario",
                table: "T_Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Solicitud_T_OrdenTrabajo_idOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Solicitud_T_Servicio_idServicio",
                table: "T_Solicitud");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rol_T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rubro_T_RubroidRubro",
                table: "T_Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_TipoDocumento_T_TipoDocumentoidDocumento",
                table: "T_Usuario");

            migrationBuilder.DropTable(
                name: "T_Entregable");

            migrationBuilder.DropTable(
                name: "T_Rol");

            migrationBuilder.DropTable(
                name: "T_TipoDocumento");

            migrationBuilder.DropTable(
                name: "T_Versionamiento");

            migrationBuilder.DropTable(
                name: "T_OrdenTrabajo");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_T_RubroidRubro",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_T_TipoDocumentoidDocumento",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Solicitud_idOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropIndex(
                name: "IX_T_Solicitud_idServicio",
                table: "T_Solicitud");

            migrationBuilder.DropIndex(
                name: "IX_T_Cliente_T_UsuarioidUsuario",
                table: "T_Cliente");

            migrationBuilder.DropColumn(
                name: "T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "T_RubroidRubro",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "T_TipoDocumentoidDocumento",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "idOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "T_Solicitud");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "nombrepdf",
                table: "T_Cotizacion",
                newName: "pdfCotizar");

            migrationBuilder.RenameColumn(
                name: "ruc",
                table: "T_Cliente",
                newName: "idRubro");

            migrationBuilder.RenameColumn(
                name: "T_UsuarioidUsuario",
                table: "T_Cliente",
                newName: "tipoEmpresa");

            migrationBuilder.RenameColumn(
                name: "TipoDocumemnto",
                table: "AspNetUsers",
                newName: "Dni");

            migrationBuilder.AddColumn<string>(
                name: "nombreServicio",
                table: "T_Solicitud",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "razonSocial",
                table: "T_Cliente",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "idUsuario",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "T_Cliente",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tipoEmpresa",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "T_Cliente",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "documento",
                table: "T_Cliente",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "T_ClientexServicio",
                columns: table => new
                {
                    idClientexServicio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    detalle = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    horario = table.Column<string>(nullable: true),
                    idCliente = table.Column<int>(nullable: false),
                    idServicio = table.Column<int>(nullable: false),
                    nombreServicio = table.Column<string>(nullable: true),
                    progreso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ClientexServicio", x => x.idClientexServicio);
                    table.ForeignKey(
                        name: "FK_T_ClientexServicio_T_Cliente_idCliente",
                        column: x => x.idCliente,
                        principalTable: "T_Cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_ClientexServicio_T_Servicio_idServicio",
                        column: x => x.idServicio,
                        principalTable: "T_Servicio",
                        principalColumn: "idServicio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Horario",
                columns: table => new
                {
                    idHorario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    duracion = table.Column<string>(nullable: true),
                    fechainicio = table.Column<DateTime>(nullable: false),
                    idClientexServicio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Horario", x => x.idHorario);
                    table.ForeignKey(
                        name: "FK_T_Horario_T_ClientexServicio_idClientexServicio",
                        column: x => x.idClientexServicio,
                        principalTable: "T_ClientexServicio",
                        principalColumn: "idClientexServicio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Cliente_idRubro",
                table: "T_Cliente",
                column: "idRubro");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cliente_idUsuario",
                table: "T_Cliente",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_T_ClientexServicio_idCliente",
                table: "T_ClientexServicio",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_T_ClientexServicio_idServicio",
                table: "T_ClientexServicio",
                column: "idServicio");

            migrationBuilder.CreateIndex(
                name: "IX_T_Horario_idClientexServicio",
                table: "T_Horario",
                column: "idClientexServicio");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cliente_T_Rubro_idRubro",
                table: "T_Cliente",
                column: "idRubro",
                principalTable: "T_Rubro",
                principalColumn: "idRubro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cliente_T_Usuario_idUsuario",
                table: "T_Cliente",
                column: "idUsuario",
                principalTable: "T_Usuario",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
