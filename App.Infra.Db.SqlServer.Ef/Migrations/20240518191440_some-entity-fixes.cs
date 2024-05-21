using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class someentityfixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Experts");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 453, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 18, 12, 14, 39, 452, DateTimeKind.Local).AddTicks(7340));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Experts",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 158, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9775));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 17, 7, 49, 36, 157, DateTimeKind.Local).AddTicks(9948));
        }
    }
}
