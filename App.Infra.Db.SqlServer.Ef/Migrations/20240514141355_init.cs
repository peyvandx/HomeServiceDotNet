using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App.Infra.Db.SqlServer.Ef.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SignUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SignUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkExperience = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    SignUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experts_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Experts_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpertService",
                columns: table => new
                {
                    ExpertsId = table.Column<int>(type: "int", nullable: false),
                    ServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertService", x => new { x.ExpertsId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_ExpertService_Experts_ExpertsId",
                        column: x => x.ExpertsId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertService_Services_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerDescription = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    SelfRate = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proposals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpertDescription = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    SuggestedPrice = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proposals_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proposals_ServiceRequests_ServiceRequestId",
                        column: x => x.ServiceRequestId,
                        principalTable: "ServiceRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(3858), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "دکوراسیون ساختمان" },
                    { 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(3894), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "تاسیسات ساختمان" },
                    { 3, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(3897), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "وسایل نقلیه" },
                    { 4, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(3899), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "اسباب کشی و باربری" },
                    { 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(3901), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "لوازم خانگی" },
                    { 6, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(3903), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "خدمات اداری" },
                    { 7, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(3905), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "دیجیتال و نرم افزار" },
                    { 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(3907), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "نظافت و بهداشت" },
                    { 9, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(3909), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "پزشکی و سلامت" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2560), false, "آذربایجان شرقی" },
                    { 2, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2568), false, "آذربایجان غربی" },
                    { 3, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2571), false, "اردبیل" },
                    { 4, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2573), false, "اصفهان" },
                    { 5, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2574), false, "البرز" },
                    { 6, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2576), false, "ایلام" },
                    { 7, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2578), false, "بوشهر" },
                    { 8, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2580), false, "تهران" },
                    { 9, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2582), false, "چهارمحال و بختیاری" },
                    { 10, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2584), false, "خراسان جنوبی" },
                    { 11, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2585), false, "خراسان رضوی" },
                    { 12, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2587), false, "خراسان شمالی" },
                    { 13, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2589), false, "خوزستان" },
                    { 14, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2591), false, "زنجان" },
                    { 15, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2592), false, "سمنان" },
                    { 16, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2594), false, "سیستان و بلوچستان" },
                    { 17, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2596), false, "فارس" },
                    { 18, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2598), false, "قزوین" },
                    { 19, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2599), false, "قم" },
                    { 20, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2601), false, "کردستان" },
                    { 21, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2603), false, "کرمان" },
                    { 22, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2604), false, "کرمانشاه" },
                    { 23, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2606), false, "کهگیلویه و بویراحمد" },
                    { 24, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2608), false, "گلستان" },
                    { 25, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2610), false, "گیلان" },
                    { 26, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2611), false, "لرستان" },
                    { 27, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2613), false, "مازندران" },
                    { 28, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2615), false, "مرکزی" },
                    { 29, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2616), false, "هرمزگان" },
                    { 30, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2618), false, "همدان" },
                    { 31, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(2620), false, "یزد" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1818), false, "آذربایجان شرقی", 1 },
                    { 2, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1831), false, "آذربایجان غربی", 2 },
                    { 3, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1834), false, "اردبیل", 3 },
                    { 4, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1836), false, "اصفهان", 4 },
                    { 5, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1838), false, "البرز", 5 },
                    { 6, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1840), false, "ایلام", 6 },
                    { 7, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1841), false, "بوشهر", 7 },
                    { 8, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1843), false, "تهران", 8 },
                    { 9, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1845), false, "چهارمحال و بختیاری", 9 },
                    { 10, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1848), false, "خراسان جنوبی", 10 },
                    { 11, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1849), false, "خراسان رضوی", 11 },
                    { 12, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1851), false, "خراسان شمالی", 12 },
                    { 13, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1853), false, "خوزستان", 13 },
                    { 14, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1855), false, "زنجان", 14 },
                    { 15, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1857), false, "سمنان", 15 },
                    { 16, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1859), false, "سیستان و بلوچستان", 16 },
                    { 17, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1860), false, "فارس", 17 },
                    { 18, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1862), false, "قزوین", 18 },
                    { 19, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1864), false, "قم", 19 },
                    { 20, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1866), false, "کردستان", 20 },
                    { 21, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1868), false, "کرمان", 21 },
                    { 22, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1870), false, "کرمانشاه", 22 },
                    { 23, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1872), false, "کهگیلویه و بویراحمد", 23 },
                    { 24, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1873), false, "گلستان", 24 },
                    { 25, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1875), false, "گیلان", 25 },
                    { 26, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1877), false, "لرستان", 26 },
                    { 27, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1879), false, "مازندران", 27 },
                    { 28, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1881), false, "مرکزی", 28 },
                    { 29, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1882), false, "هرمزگان", 29 },
                    { 30, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1884), false, "همدان", 30 },
                    { 31, new DateTime(2024, 5, 14, 7, 13, 55, 253, DateTimeKind.Local).AddTicks(1886), false, "یزد", 31 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Image", "IsDeleted", "Title", "WorkExperience" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5557), "", "", false, "کاشی و سرامیک", 0 },
                    { 2, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5570), "", "", false, "بنایی ساختمان", 0 },
                    { 3, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5573), "", "", false, "گچ کاری", 0 },
                    { 4, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5575), "", "", false, "کارگر ساده", 0 },
                    { 5, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5577), "", "", false, "بازسازی", 0 },
                    { 6, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5579), "", "", false, "کانال سازی و دریچه کولر", 0 },
                    { 7, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5581), "", "", false, "عایق کاری و ایزوگام", 0 },
                    { 8, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5583), "", "", false, "سنگ کاری", 0 },
                    { 9, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5585), "", "", false, "سیمان کاری", 0 },
                    { 10, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5587), "", "", false, "نقاشی ساختمان", 0 },
                    { 11, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5589), "", "", false, "کابینت", 0 },
                    { 12, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5591), "", "", false, "کاغذ دیواری", 0 },
                    { 13, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5593), "", "", false, "نجاری", 0 },
                    { 14, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5595), "", "", false, "کفسابی", 0 },
                    { 15, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5597), "", "", false, "کفپوش", 0 },
                    { 16, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5599), "", "", false, "پارکت", 0 },
                    { 17, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5601), "", "", false, "لمینت", 0 },
                    { 18, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5604), "", "", false, "موکت", 0 },
                    { 19, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5606), "", "", false, "دوخت پرده", 0 },
                    { 20, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5608), "", "", false, "مبلمان", 0 },
                    { 21, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5610), "", "", false, "سرویس خواب", 0 },
                    { 22, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5612), "", "", false, "سقف کاذب", 0 },
                    { 23, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5614), "", "", false, "نمای ساختمان", 0 },
                    { 24, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5616), "", "", false, "تعمیر نمای ساختمان", 0 },
                    { 25, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5618), "", "", false, "شیشه بری", 0 },
                    { 26, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5620), "", "", false, "توری پنجره", 0 },
                    { 27, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5622), "", "", false, "نصب درب چوبی", 0 },
                    { 28, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5624), "", "", false, "جوشکاری و آهنگری", 0 },
                    { 29, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5626), "", "", false, "کلید سازی", 0 },
                    { 30, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5628), "", "", false, "گل و گیاه آپارتمانی", 0 },
                    { 31, 1, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5630), "", "", false, "باغبانی", 0 },
                    { 32, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5632), "", "", false, "کولر آبی", 0 },
                    { 33, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5634), "", "", false, "کولر گازی", 0 },
                    { 34, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5636), "", "", false, "پکیج", 0 },
                    { 35, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5639), "", "", false, "آبگرمکن", 0 },
                    { 36, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5641), "", "", false, "فن‌کویل", 0 },
                    { 37, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5643), "", "", false, "چیلر و هواساز", 0 },
                    { 38, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5645), "", "", false, "رادیاتور شوفاژ", 0 },
                    { 39, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5647), "", "", false, "موتورخانه", 0 },
                    { 40, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5649), "", "", false, "بخاری گازی", 0 },
                    { 41, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5651), "", "", false, "شومینه گازی", 0 },
                    { 42, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5653), "", "", false, "لوله کشی", 0 },
                    { 43, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5655), "", "", false, "شیرآلات ساختمانی", 0 },
                    { 44, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5657), "", "", false, "لوله بازکنی", 0 },
                    { 45, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5659), "", "", false, "توالت فرنگی", 0 },
                    { 46, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5661), "", "", false, "پمپ آب", 0 },
                    { 47, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5663), "", "", false, "لوله‌ کشی گاز", 0 },
                    { 48, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5665), "", "", false, "تخلیه چاه", 0 },
                    { 49, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5667), "", "", false, "فلاش تانک", 0 },
                    { 50, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5668), "", "", false, "روشویی و دست‌شور", 0 },
                    { 51, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5671), "", "", false, "سینک ظرفشویی", 0 },
                    { 52, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5673), "", "", false, "برق کاری ساختمان", 0 },
                    { 53, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5675), "", "", false, "آیفون تصویری", 0 },
                    { 54, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5677), "", "", false, "لوستر", 0 },
                    { 55, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5678), "", "", false, "دوربین مداربسته", 0 },
                    { 56, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5680), "", "", false, "هواکش", 0 },
                    { 57, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5682), "", "", false, "آنتن دیجیتال", 0 },
                    { 58, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5684), "", "", false, "نورپردازی ساختمان", 0 },
                    { 59, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5686), "", "", false, "تایمر مشاعات", 0 },
                    { 60, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5688), "", "", false, "جعبه فیوز", 0 },
                    { 61, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5690), "", "", false, "داکت کشی و ترانکینگ", 0 },
                    { 62, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5692), "", "", false, "سیم کشی تلفن", 0 },
                    { 63, 2, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5694), "", "", false, "سیم کشی سانترال", 0 },
                    { 64, 3, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5696), "", "", false, "صافکاری و نقاشی خودرو", 0 },
                    { 65, 3, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5698), "", "", false, "تعویض روغن", 0 },
                    { 66, 3, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5700), "", "", false, "تعمیر خودرو", 0 },
                    { 67, 3, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5702), "", "", false, "برق خودرو", 0 },
                    { 68, 4, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5705), "", "", false, "اسباب کشی", 0 },
                    { 69, 4, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5707), "", "", false, "حمل بار", 0 },
                    { 70, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5709), "", "", false, "یخچال", 0 },
                    { 71, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5711), "", "", false, "ماشین ظرفشویی", 0 },
                    { 72, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5713), "", "", false, "مایکروفر", 0 },
                    { 73, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5715), "", "", false, "اجاق برقی", 0 },
                    { 74, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5717), "", "", false, "هود آشپزخانه", 0 },
                    { 75, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5719), "", "", false, "اجاق گاز", 0 },
                    { 76, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5721), "", "", false, "ماشین لباسشویی", 0 },
                    { 77, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5723), "", "", false, "اتو بخار", 0 },
                    { 78, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5725), "", "", false, "اتو پرس", 0 },
                    { 79, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5727), "", "", false, "جاروبرقی", 0 },
                    { 80, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5729), "", "", false, "جارو شارژی", 0 },
                    { 81, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5731), "", "", false, "تلویزیون", 0 },
                    { 82, 5, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5762), "", "", false, "سینما خانگی", 0 },
                    { 83, 6, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5765), "", "", false, "دستگاه کپی", 0 },
                    { 84, 6, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5768), "", "", false, "فکس", 0 },
                    { 85, 6, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5770), "", "", false, "پرینتر", 0 },
                    { 86, 6, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5772), "", "", false, "پارتیشن اداری", 0 },
                    { 87, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5789), "", "", false, "نظافت دوره ای", 0 },
                    { 88, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5791), "", "", false, "نظافت منزل", 0 },
                    { 89, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5793), "", "", false, "نظافت ساختمان", 0 },
                    { 90, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5795), "", "", false, "نظافت شرکت و اداره", 0 },
                    { 91, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5797), "", "", false, "ضدعفونی منزل و محل کار", 0 },
                    { 92, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5799), "", "", false, "خشکشویی آنلاین", 0 },
                    { 93, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5801), "", "", false, "خشکشویی پرده", 0 },
                    { 94, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5803), "", "", false, "قالیشویی آنلاین", 0 },
                    { 95, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5805), "", "", false, "مبل شویی", 0 },
                    { 96, 8, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5807), "", "", false, "سمپاشی منازل", 0 },
                    { 97, 7, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5774), "", "", false, "تعمیر موبایل", 0 },
                    { 98, 7, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5776), "", "", false, "تعمیر لپ‌تاپ", 0 },
                    { 99, 7, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5778), "", "", false, "تعمیر سخت افزار کامپیوتر", 0 },
                    { 100, 7, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5780), "", "", false, "نصب نرم افزار", 0 },
                    { 101, 7, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5782), "", "", false, "نصب ویندوز در محل", 0 },
                    { 102, 7, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5784), "", "", false, "تعمیر مودم اینترنت", 0 },
                    { 103, 7, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5786), "", "", false, "راه‌ اندازی شبکه کامپیوتری", 0 },
                    { 104, 9, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5809), "", "", false, "آزمایش در محل", 0 },
                    { 105, 9, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5811), "", "", false, "پرستاری در منزل", 0 },
                    { 106, 9, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5813), "", "", false, "ویزیت پزشک در منزل", 0 },
                    { 107, 9, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5815), "", "", false, "نوار قلب در محل", 0 },
                    { 108, 9, new DateTime(2024, 5, 14, 7, 13, 55, 252, DateTimeKind.Local).AddTicks(5817), "", "", false, "فیزیوتراپی در منزل", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AdminId",
                table: "Comments",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomerId",
                table: "Comments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ExpertId",
                table: "Comments",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AdminId",
                table: "Customers",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Experts_AddressId",
                table: "Experts",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experts_AdminId",
                table: "Experts",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpertService_ServicesId",
                table: "ExpertService",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_ExpertId",
                table: "Proposals",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_ServiceRequestId",
                table: "Proposals",
                column: "ServiceRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_CustomerId",
                table: "ServiceRequests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_ExpertId",
                table: "ServiceRequests",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_ServiceId",
                table: "ServiceRequests",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CategoryId",
                table: "Services",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ExpertId",
                table: "Skills",
                column: "ExpertId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ExpertService");

            migrationBuilder.DropTable(
                name: "Proposals");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "ServiceRequests");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
