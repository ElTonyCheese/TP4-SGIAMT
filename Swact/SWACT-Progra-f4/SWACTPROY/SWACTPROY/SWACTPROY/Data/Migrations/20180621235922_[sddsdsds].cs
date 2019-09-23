using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SWACTPROY.Data.Migrations
{
    public partial class sddsdsds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Usuario_T_Rol_T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropTable(
                name: "T_Rol");

            migrationBuilder.DropIndex(
                name: "IX_T_Usuario_T_RolidRol",
                table: "T_Usuario");

            migrationBuilder.DropColumn(
                name: "T_RolidRol",
                table: "T_Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "T_RolidRol",
                table: "T_Usuario",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "T_Rol",
                columns: table => new
                {
                    idRol = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    detalleRol = table.Column<string>(nullable: true),
                    nombreRol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Rol", x => x.idRol);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_T_RolidRol",
                table: "T_Usuario",
                column: "T_RolidRol");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Usuario_T_Rol_T_RolidRol",
                table: "T_Usuario",
                column: "T_RolidRol",
                principalTable: "T_Rol",
                principalColumn: "idRol",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
