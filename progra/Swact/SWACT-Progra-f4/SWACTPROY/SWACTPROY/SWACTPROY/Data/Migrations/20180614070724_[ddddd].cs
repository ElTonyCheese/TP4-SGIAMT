using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class ddddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Cliente_T_Usuario_T_UsuarioidUsuario",
                table: "T_Cliente");

            migrationBuilder.DropIndex(
                name: "IX_T_Cliente_T_UsuarioidUsuario",
                table: "T_Cliente");

            migrationBuilder.DropColumn(
                name: "T_UsuarioidUsuario",
                table: "T_Cliente");

            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "T_Cliente",
                newName: "idRubro");

            migrationBuilder.AlterColumn<long>(
                name: "ruc",
                table: "T_Cliente",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "idUsuario",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_T_Cliente_idRubro",
                table: "T_Cliente",
                column: "idRubro");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cliente_idUsuario",
                table: "T_Cliente",
                column: "idUsuario");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Cliente_T_Rubro_idRubro",
                table: "T_Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Cliente_T_Usuario_idUsuario",
                table: "T_Cliente");

            migrationBuilder.DropIndex(
                name: "IX_T_Cliente_idRubro",
                table: "T_Cliente");

            migrationBuilder.DropIndex(
                name: "IX_T_Cliente_idUsuario",
                table: "T_Cliente");

            migrationBuilder.RenameColumn(
                name: "idRubro",
                table: "T_Cliente",
                newName: "telefono");

            migrationBuilder.AlterColumn<int>(
                name: "ruc",
                table: "T_Cliente",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "idUsuario",
                table: "T_Cliente",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "T_UsuarioidUsuario",
                table: "T_Cliente",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Cliente_T_UsuarioidUsuario",
                table: "T_Cliente",
                column: "T_UsuarioidUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Cliente_T_Usuario_T_UsuarioidUsuario",
                table: "T_Cliente",
                column: "T_UsuarioidUsuario",
                principalTable: "T_Usuario",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
