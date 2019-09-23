using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class llololololo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Solicitud_T_OrdenTrabajo_idOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropIndex(
                name: "IX_T_Solicitud_idOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropColumn(
                name: "idOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.AddColumn<int>(
                name: "T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Solicitud_T_OrdenTrabajo_T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropIndex(
                name: "IX_T_Solicitud_T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.DropColumn(
                name: "T_OrdenTrabajoidOrdenTrabajo",
                table: "T_Solicitud");

            migrationBuilder.AddColumn<int>(
                name: "idOrdenTrabajo",
                table: "T_Solicitud",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_Solicitud_idOrdenTrabajo",
                table: "T_Solicitud",
                column: "idOrdenTrabajo");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Solicitud_T_OrdenTrabajo_idOrdenTrabajo",
                table: "T_Solicitud",
                column: "idOrdenTrabajo",
                principalTable: "T_OrdenTrabajo",
                principalColumn: "idOrdenTrabajo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
