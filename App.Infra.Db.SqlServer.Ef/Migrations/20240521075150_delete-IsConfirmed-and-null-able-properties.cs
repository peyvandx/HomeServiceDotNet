using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class deleteIsConfirmedandnullableproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Admins_AdminId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Experts_Admins_AdminId",
                table: "Experts");

            migrationBuilder.DropIndex(
                name: "IX_Experts_AddressId",
                table: "Experts");

            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Experts");

            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Admins");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "Experts",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Experts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Experts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SignUpDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SignUpDate",
                table: "Admins",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "Admins",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000);

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "FirstName", "IsDeleted", "LastName", "ProfileImage", "SignUpDate" },
                values: new object[] { 1, "ادمین", false, "ادمینیان پور", "/UserAssets/img/admin/1.jpg", new DateTime(2024, 5, 21, 0, 51, 49, 360, DateTimeKind.Local).AddTicks(8561) });

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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AdminId", "FirstName", "IsDeleted", "LastName", "ProfileImage", "SignUpDate" },
                values: new object[,]
                {
                    { 2, null, "علی", false, "محمدی", "/UserAssets/img/customer/1.jpg", new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(62) },
                    { 3, null, "سحر", false, "رمضانی", "/UserAssets/img/customer/2.jpg", new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(79) },
                    { 4, null, "مریم", false, "اکبری", "/UserAssets/img/customer/3.jpg", new DateTime(2024, 5, 21, 0, 51, 49, 363, DateTimeKind.Local).AddTicks(81) }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Experts_AddressId",
                table: "Experts",
                column: "AddressId",
                unique: true,
                filter: "[AddressId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Admins_AdminId",
                table: "Customers",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Experts_Admins_AdminId",
                table: "Experts",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Admins_AdminId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Experts_Admins_AdminId",
                table: "Experts");

            migrationBuilder.DropIndex(
                name: "IX_Experts_AddressId",
                table: "Experts");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "Experts",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Experts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Experts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Experts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SignUpDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SignUpDate",
                table: "Admins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImage",
                table: "Admins",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Admins",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Experts_AddressId",
                table: "Experts",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Admins_AdminId",
                table: "Customers",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Experts_Admins_AdminId",
                table: "Experts",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
