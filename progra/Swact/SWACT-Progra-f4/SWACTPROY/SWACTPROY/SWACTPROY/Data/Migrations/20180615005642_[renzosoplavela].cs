using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class renzosoplavela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Entregable");

            migrationBuilder.DropColumn(
                name: "fechaRespuesta",
                table: "T_Versionamiento");

            migrationBuilder.AlterColumn<int>(
                name: "precio",
                table: "T_Versionamiento",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaCreacion",
                table: "T_Versionamiento",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaModificacion",
                table: "T_Versionamiento",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idSolicitud",
                table: "T_Versionamiento",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "T_Entregables",
                columns: table => new
                {
                    idEntregable = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    avance = table.Column<int>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false),
                    fechaModificacion = table.Column<DateTime>(nullable: false),
                    horaFin = table.Column<string>(nullable: true),
                    horaInicio = table.Column<string>(nullable: true),
                    idOrdenTrabajo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Entregables", x => x.idEntregable);
                    table.ForeignKey(
                        name: "FK_T_Entregables_T_OrdenTrabajo_idOrdenTrabajo",
                        column: x => x.idOrdenTrabajo,
                        principalTable: "T_OrdenTrabajo",
                        principalColumn: "idOrdenTrabajo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Entregables_idOrdenTrabajo",
                table: "T_Entregables",
                column: "idOrdenTrabajo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Entregables");

            migrationBuilder.DropColumn(
                name: "fechaModificacion",
                table: "T_Versionamiento");

            migrationBuilder.DropColumn(
                name: "idSolicitud",
                table: "T_Versionamiento");

            migrationBuilder.AlterColumn<int>(
                name: "precio",
                table: "T_Versionamiento",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaCreacion",
                table: "T_Versionamiento",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaRespuesta",
                table: "T_Versionamiento",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                name: "IX_T_Entregable_idOrdenTrabajo",
                table: "T_Entregable",
                column: "idOrdenTrabajo");
        }
    }
}
