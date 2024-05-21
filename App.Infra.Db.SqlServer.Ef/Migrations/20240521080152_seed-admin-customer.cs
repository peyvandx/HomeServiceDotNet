using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class seedadmincustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 72, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Expert", "EXPERT" },
                    { 3, null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdminId", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "ExpertId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, 1, "37f7baad-b223-4cc4-a8cc-cd3b1a7330f7", null, "Admin@gmail.com", false, null, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEMQDHc0Fbq14Z+nd8Gujer2dkwpoI9Xs1DHKZSgOTenBngHDpp7nwQh5p8pYW8vLPA==", "09377507920", false, "011aacde-b90a-4b72-94dd-d678336b1bd7", false, "Admin@gmail.com" },
                    { 2, 0, null, "929d148a-e105-4da4-8598-f6c5a94f9310", 2, "Ali@gmail.com", false, null, false, null, "ALI@GMAIL.COM", "ALI@GMAIL.COM", "AQAAAAIAAYagAAAAECuXQsAFhHILYbE4ybcm3oBW+EF0NO4wPGFM2HOECH4QUAbtsesFO4h3qXg2gPWrMQ==", "09377507920", false, "fb3fe48f-69a6-483a-875e-a0963f8ad59b", false, "Ali@gmail.com" },
                    { 3, 0, null, "62751c1d-1c27-413a-b9f7-49e44658857c", 3, "Sahar@gmail.com", false, null, false, null, "SAHAR@GMAIL.COM", "SAHAR@GMAIL.COM", "AQAAAAIAAYagAAAAEApjf3JWjFHM2c+vmq3ieko9a4NeX5IWmG7u+NbqfBbFD9gQAOAQJVM6OqJhNapW1A==", "09377507920", false, "fc9a8bee-d7cb-409f-965b-a6bce32890a9", false, "Sahar@gmail.com" },
                    { 4, 0, null, "b46845fe-4d6d-44c0-aa03-066addab6e97", 4, "Maryam@gmail.com", false, null, false, null, "MARYAM@GMAIL.COM", "MARYAM@GMAIL.COM", "AQAAAAIAAYagAAAAEK4J41Iv+0/CHU1X7Acdby9AJNOm4/GopCO//3Kx9jbv7fkLEJDfl/HbOBhgGYXJBg==", "09377507920", false, "4db24bb6-8001-46de-95e0-dbaec9740cf0", false, "Maryam@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "SignUpDate",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 75, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 77, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 1, 1, 51, 76, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "SignUpDate",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 360, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "SignUpDate",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "SignUpDate",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "SignUpDate",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 364, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(3587));
        }
    }
}
