using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionTienda.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id",
                table: "Articulo");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Categoria",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Categoria_Id",
                table: "Articulo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id",
                table: "Articulo",
                column: "Categoria_Id",
                principalTable: "Categoria",
                principalColumn: "Categoria_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Categoria");

            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Categoria");

            migrationBuilder.AlterColumn<int>(
                name: "Categoria_Id",
                table: "Articulo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulo_Categoria_Categoria_Id",
                table: "Articulo",
                column: "Categoria_Id",
                principalTable: "Categoria",
                principalColumn: "Categoria_Id");
        }
    }
}
