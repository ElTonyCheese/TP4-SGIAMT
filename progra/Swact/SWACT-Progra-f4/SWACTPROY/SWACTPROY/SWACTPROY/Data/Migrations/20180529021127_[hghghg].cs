using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class hghghg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cantidadPersonal",
                table: "T_Cotizacion");

            migrationBuilder.DropColumn(
                name: "detalle",
                table: "T_Cotizacion");

            migrationBuilder.DropColumn(
                name: "fechaElaboracion",
                table: "T_Cotizacion");

            migrationBuilder.DropColumn(
                name: "plandeTrabajo",
                table: "T_Cotizacion");

            migrationBuilder.DropColumn(
                name: "precio",
                table: "T_Cotizacion");

            migrationBuilder.AddColumn<string>(
                name: "pdfCotizar",
                table: "T_Cotizacion",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Dni",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "T_Servicio",
                columns: table => new
                {
                    idServicio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    detalle = table.Column<string>(nullable: true),
                    ganancia = table.Column<int>(nullable: false),
                    idRubro = table.Column<int>(nullable: false),
                    nombreServicio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Servicio", x => x.idServicio);
                    table.ForeignKey(
                        name: "FK_T_Servicio_T_Rubro_idRubro",
                        column: x => x.idRubro,
                        principalTable: "T_Rubro",
                        principalColumn: "idRubro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Servicio_idRubro",
                table: "T_Servicio",
                column: "idRubro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Servicio");

            migrationBuilder.DropColumn(
                name: "pdfCotizar",
                table: "T_Cotizacion");

            migrationBuilder.AddColumn<int>(
                name: "cantidadPersonal",
                table: "T_Cotizacion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "detalle",
                table: "T_Cotizacion",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaElaboracion",
                table: "T_Cotizacion",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "plandeTrabajo",
                table: "T_Cotizacion",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "precio",
                table: "T_Cotizacion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Dni",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
