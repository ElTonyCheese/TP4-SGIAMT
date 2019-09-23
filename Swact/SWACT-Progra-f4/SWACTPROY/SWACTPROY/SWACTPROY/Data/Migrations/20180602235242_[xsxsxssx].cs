using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class xsxsxssx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Solicitud_T_Usuario_t_UsuarioidUsuario",
                table: "T_Solicitud");

            migrationBuilder.DropIndex(
                name: "IX_T_Solicitud_t_UsuarioidUsuario",
                table: "T_Solicitud");

            migrationBuilder.DropColumn(
                name: "t_UsuarioidUsuario",
                table: "T_Solicitud");

            migrationBuilder.DropColumn(
                name: "ganancia",
                table: "T_Servicio");

            migrationBuilder.AddColumn<string>(
                name: "documento",
                table: "T_Cliente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tipoEmpresa",
                table: "T_Cliente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "documento",
                table: "T_Cliente");

            migrationBuilder.DropColumn(
                name: "tipoEmpresa",
                table: "T_Cliente");

            migrationBuilder.AddColumn<string>(
                name: "t_UsuarioidUsuario",
                table: "T_Solicitud",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ganancia",
                table: "T_Servicio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_Solicitud_t_UsuarioidUsuario",
                table: "T_Solicitud",
                column: "t_UsuarioidUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Solicitud_T_Usuario_t_UsuarioidUsuario",
                table: "T_Solicitud",
                column: "t_UsuarioidUsuario",
                principalTable: "T_Usuario",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
