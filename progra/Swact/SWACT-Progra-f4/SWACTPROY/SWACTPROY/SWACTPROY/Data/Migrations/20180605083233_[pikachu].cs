using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class pikachu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nombreServicio",
                table: "T_Solicitud",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "razonSocial",
                table: "T_Cliente",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "T_Cliente",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "T_Cliente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

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
                name: "IX_T_Cotizacion_idSolicitud",
                table: "T_Cotizacion",
                column: "idSolicitud");

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
                name: "FK_T_Cotizacion_T_Solicitud_idSolicitud",
                table: "T_Cotizacion",
                column: "idSolicitud",
                principalTable: "T_Solicitud",
                principalColumn: "idSolicitud",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Cotizacion_T_Solicitud_idSolicitud",
                table: "T_Cotizacion");

            migrationBuilder.DropTable(
                name: "T_Horario");

            migrationBuilder.DropTable(
                name: "T_ClientexServicio");

            migrationBuilder.DropIndex(
                name: "IX_T_Cotizacion_idSolicitud",
                table: "T_Cotizacion");

            migrationBuilder.AlterColumn<string>(
                name: "nombreServicio",
                table: "T_Solicitud",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "razonSocial",
                table: "T_Cliente",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
