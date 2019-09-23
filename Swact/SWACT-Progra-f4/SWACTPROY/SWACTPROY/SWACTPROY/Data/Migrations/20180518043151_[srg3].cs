using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class srg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "idUsuario",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "T_Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<string>(nullable: false),
                    apellidomaterno = table.Column<string>(nullable: true),
                    apellidopaterno = table.Column<string>(nullable: true),
                    contraseña = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    dni = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    nombre = table.Column<string>(nullable: true),
                    telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Solicitud_idCliente",
                table: "T_Solicitud",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cliente_idUsuario",
                table: "T_Cliente",
                column: "idUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cliente_T_Usuario_idUsuario",
                table: "T_Cliente",
                column: "idUsuario",
                principalTable: "T_Usuario",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Solicitud_T_Cliente_idCliente",
                table: "T_Solicitud",
                column: "idCliente",
                principalTable: "T_Cliente",
                principalColumn: "idCliente",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Cliente_T_Usuario_idUsuario",
                table: "T_Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Solicitud_T_Cliente_idCliente",
                table: "T_Solicitud");

            migrationBuilder.DropTable(
                name: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Solicitud_idCliente",
                table: "T_Solicitud");

            migrationBuilder.DropIndex(
                name: "IX_T_Cliente_idUsuario",
                table: "T_Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "idUsuario",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
