﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValasztasWebApp.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_876 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    RovidNev = table.Column<string>(type: "TEXT", nullable: false),
                    TeljesNev = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.RovidNev);
                });

            migrationBuilder.CreateTable(
                name: "Jeloltek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nev = table.Column<string>(type: "TEXT", nullable: false),
                    Kerulet = table.Column<int>(type: "INTEGER", nullable: false),
                    Szavazatok = table.Column<int>(type: "INTEGER", nullable: false),
                    PartRovidNev = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jeloltek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jeloltek_Parts_PartRovidNev",
                        column: x => x.PartRovidNev,
                        principalTable: "Parts",
                        principalColumn: "RovidNev",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jeloltek_PartRovidNev",
                table: "Jeloltek",
                column: "PartRovidNev");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jeloltek");

            migrationBuilder.DropTable(
                name: "Parts");
        }
    }
}
