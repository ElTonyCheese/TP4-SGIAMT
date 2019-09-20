using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class srg45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "t_UsuarioidUsuario",
                table: "T_Solicitud",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "razonSocial",
                table: "T_Cliente",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "razonSocial",
                table: "T_Cliente",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
