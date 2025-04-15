using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerformansTakip.Migrations
{
    /// <inheritdoc />
    public partial class OgrenciGunlukTakipAlanlariEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FormaGiydi",
                table: "Ogrenciler",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "GunlukNot",
                table: "Ogrenciler",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "OdevYapti",
                table: "Ogrenciler",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SinavNotu",
                table: "Ogrenciler",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaGiydi",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "GunlukNot",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "OdevYapti",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "SinavNotu",
                table: "Ogrenciler");
        }
    }
}
