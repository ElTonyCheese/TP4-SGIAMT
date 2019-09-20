using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class ssssss74 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Solicitud_T_OrdenTrabajo_T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rol_T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_TipoDocumento_T_TipoDocumentoidDocumento",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_T_TipoDocumentoidDocumento",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Solicitud_T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropColumn(
                name: "T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "T_TipoDocumentoidDocumento",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.RenameColumn(
                name: "dni",
                table: "T_Usuario",
                newName: "idrol");

            migrationBuilder.AddColumn<int>(
                name: "documento",
                table: "T_Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "iddocumento",
                table: "T_Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_iddocumento",
                table: "T_Usuario",
                column: "iddocumento");

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_idrol",
                table: "T_Usuario",
                column: "idrol");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_TipoDocumento_iddocumento",
                table: "T_Usuario",
                column: "iddocumento",
                principalTable: "T_TipoDocumento",
                principalColumn: "idDocumento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rol_idrol",
                table: "T_Usuario",
                column: "idrol",
                principalTable: "T_Rol",
                principalColumn: "idRol",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_TipoDocumento_iddocumento",
                table: "T_Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rol_idrol",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_iddocumento",
                table: "T_Usuario");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_idrol",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "documento",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "iddocumento",
                table: "T_Usuario");

            migrationBuilder.RenameColumn(
                name: "idrol",
                table: "T_Usuario",
                newName: "dni");

            migrationBuilder.AddColumn<int>(
                name: "T_RolidRol",
                table: "T_Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "T_TipoDocumentoidDocumento",
                table: "T_Usuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_T_RolidRol",
                table: "T_Usuario",
                column: "T_RolidRol");

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_T_TipoDocumentoidDocumento",
                table: "T_Usuario",
                column: "T_TipoDocumentoidDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_T_Solicitud_T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud",
                column: "T_OrdenTrabajoidOrdenTrabajo");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Solicitud_T_OrdenTrabajo_T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud",
                column: "T_OrdenTrabajoidOrdenTrabajo",
                principalTable: "T_OrdenTrabajo",
                principalColumn: "idOrdenTrabajo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rol_T_RolidRol",
                table: "T_Usuario",
                column: "T_RolidRol",
                principalTable: "T_Rol",
                principalColumn: "idRol",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_TipoDocumento_T_TipoDocumentoidDocumento",
                table: "T_Usuario",
                column: "T_TipoDocumentoidDocumento",
                principalTable: "T_TipoDocumento",
                principalColumn: "idDocumento",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
