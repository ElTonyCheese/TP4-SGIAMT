using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class xsxssxsxsx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rol_idrol",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_idrol",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "avance",
                table: "T_Entregables");

            migrationBuilder.DropColumn(
                name: "fechaModificacion",
                table: "T_Entregables");

            migrationBuilder.RenameColumn(
                name: "idrol",
                table: "T_Usuario",
                newName: "idRol");

            migrationBuilder.AddColumn<string>(
                name: "duracion",
                table: "T_Versionamiento",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "idRol",
                table: "T_Usuario",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "T_RolidRol",
                table: "T_Usuario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ordentrabajo",
                table: "T_Solicitud",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "horaInicio",
                table: "T_Entregables",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "horaFin",
                table: "T_Entregables",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "T_Entregables",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "idUsuario",
                table: "T_Entregables",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "precio",
                table: "T_Cotizacion",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_T_RolidRol",
                table: "T_Usuario",
                column: "T_RolidRol");

            migrationBuilder.CreateIndex(
                name: "IX_T_Entregables_idUsuario",
                table: "T_Entregables",
                column: "idUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Entregables_T_Usuario_idUsuario",
                table: "T_Entregables",
                column: "idUsuario",
                principalTable: "T_Usuario",
                principalColumn: "idUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rol_T_RolidRol",
                table: "T_Usuario",
                column: "T_RolidRol",
                principalTable: "T_Rol",
                principalColumn: "idRol",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Entregables_T_Usuario_idUsuario",
                table: "T_Entregables");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rol_T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Entregables_idUsuario",
                table: "T_Entregables");

            migrationBuilder.DropColumn(
                name: "duracion",
                table: "T_Versionamiento");

            migrationBuilder.DropColumn(
                name: "T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "ordentrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropColumn(
                name: "idUsuario",
                table: "T_Entregables");

            migrationBuilder.RenameColumn(
                name: "idRol",
                table: "T_Usuario",
                newName: "idrol");

            migrationBuilder.AlterColumn<int>(
                name: "idrol",
                table: "T_Usuario",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "horaInicio",
                table: "T_Entregables",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "horaFin",
                table: "T_Entregables",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "T_Entregables",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "avance",
                table: "T_Entregables",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaModificacion",
                table: "T_Entregables",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<double>(
                name: "precio",
                table: "T_Cotizacion",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_idrol",
                table: "T_Usuario",
                column: "idrol");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rol_idrol",
                table: "T_Usuario",
                column: "idrol",
                principalTable: "T_Rol",
                principalColumn: "idRol",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
