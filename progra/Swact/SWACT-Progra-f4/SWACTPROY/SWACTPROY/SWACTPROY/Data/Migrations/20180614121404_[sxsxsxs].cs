using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class sxsxsxs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_OrdenTrabajo_T_Usuario_T_UsuarioidUsuario",
                table: "T_OrdenTrabajo");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rubro_T_RubroidRubro",
                table: "T_Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rol_idrol",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_T_RubroidRubro",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_OrdenTrabajo_T_UsuarioidUsuario",
                table: "T_OrdenTrabajo");

            migrationBuilder.DropColumn(
                name: "T_RubroidRubro",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "T_UsuarioidUsuario",
                table: "T_OrdenTrabajo");

            migrationBuilder.RenameColumn(
                name: "idUsuario",
                table: "T_OrdenTrabajo",
                newName: "idSolicitud");

            migrationBuilder.AlterColumn<int>(
                name: "idrol",
                table: "T_Usuario",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_T_OrdenTrabajo_idSolicitud",
                table: "T_OrdenTrabajo",
                column: "idSolicitud");

            migrationBuilder.AddForeignKey(
                name: "FK_T_OrdenTrabajo_T_Solicitud_idSolicitud",
                table: "T_OrdenTrabajo",
                column: "idSolicitud",
                principalTable: "T_Solicitud",
                principalColumn: "idSolicitud",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rol_idrol",
                table: "T_Usuario",
                column: "idrol",
                principalTable: "T_Rol",
                principalColumn: "idRol",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_OrdenTrabajo_T_Solicitud_idSolicitud",
                table: "T_OrdenTrabajo");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rol_idrol",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_OrdenTrabajo_idSolicitud",
                table: "T_OrdenTrabajo");

            migrationBuilder.RenameColumn(
                name: "idSolicitud",
                table: "T_OrdenTrabajo",
                newName: "idUsuario");

            migrationBuilder.AlterColumn<int>(
                name: "idrol",
                table: "T_Usuario",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "T_RubroidRubro",
                table: "T_Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "T_UsuarioidUsuario",
                table: "T_OrdenTrabajo",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_T_RubroidRubro",
                table: "T_Usuario",
                column: "T_RubroidRubro");

            migrationBuilder.CreateIndex(
                name: "IX_T_OrdenTrabajo_T_UsuarioidUsuario",
                table: "T_OrdenTrabajo",
                column: "T_UsuarioidUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_T_OrdenTrabajo_T_Usuario_T_UsuarioidUsuario",
                table: "T_OrdenTrabajo",
                column: "T_UsuarioidUsuario",
                principalTable: "T_Usuario",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rubro_T_RubroidRubro",
                table: "T_Usuario",
                column: "T_RubroidRubro",
                principalTable: "T_Rubro",
                principalColumn: "idRubro",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rol_idrol",
                table: "T_Usuario",
                column: "idrol",
                principalTable: "T_Rol",
                principalColumn: "idRol",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
