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
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    ExpertId = table.Column<int>(type: "int", nullable: true),
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
                    { 1, new DateTime(2024, 4, 30, 7, 52, 23, 837, DateTimeKind.Local).AddTicks(8543), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "دکوراسیون ساختمان" },
                    { 2, new DateTime(2024, 4, 30, 7, 52, 23, 837, DateTimeKind.Local).AddTicks(8584), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "تاسیسات ساختمان" },
                    { 3, new DateTime(2024, 4, 30, 7, 52, 23, 837, DateTimeKind.Local).AddTicks(8587), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "وسایل نقلیه" },
                    { 4, new DateTime(2024, 4, 30, 7, 52, 23, 837, DateTimeKind.Local).AddTicks(8589), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "اسباب کشی و باربری" },
                    { 5, new DateTime(2024, 4, 30, 7, 52, 23, 837, DateTimeKind.Local).AddTicks(8591), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "لوازم خانگی" },
                    { 6, new DateTime(2024, 4, 30, 7, 52, 23, 837, DateTimeKind.Local).AddTicks(8594), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "خدمات اداری" },
                    { 7, new DateTime(2024, 4, 30, 7, 52, 23, 837, DateTimeKind.Local).AddTicks(8596), "لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم لورم ایپسوم ", "", false, "دیجیتال و نرم افزار" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7976), false, "آذربایجان شرقی" },
                    { 2, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7988), false, "آذربایجان غربی" },
                    { 3, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7990), false, "اردبیل" },
                    { 4, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7992), false, "اصفهان" },
                    { 5, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7994), false, "البرز" },
                    { 6, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7996), false, "ایلام" },
                    { 7, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7997), false, "بوشهر" },
                    { 8, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7999), false, "تهران" },
                    { 9, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8001), false, "چهارمحال و بختیاری" },
                    { 10, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8003), false, "خراسان جنوبی" },
                    { 11, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8005), false, "خراسان رضوی" },
                    { 12, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8007), false, "خراسان شمالی" },
                    { 13, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8009), false, "خوزستان" },
                    { 14, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8010), false, "زنجان" },
                    { 15, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8012), false, "سمنان" },
                    { 16, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8014), false, "سیستان و بلوچستان" },
                    { 17, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8016), false, "فارس" },
                    { 18, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8018), false, "قزوین" },
                    { 19, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8020), false, "قم" },
                    { 20, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8022), false, "کردستان" },
                    { 21, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8024), false, "کرمان" },
                    { 22, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8025), false, "کرمانشاه" },
                    { 23, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8027), false, "کهگیلویه و بویراحمد" },
                    { 24, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8029), false, "گلستان" },
                    { 25, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8031), false, "گیلان" },
                    { 26, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8033), false, "لرستان" },
                    { 27, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8035), false, "مازندران" },
                    { 28, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8037), false, "مرکزی" },
                    { 29, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8106), false, "هرمزگان" },
                    { 30, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8109), false, "همدان" },
                    { 31, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(8111), false, "یزد" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7297), false, "آذربایجان شرقی", 1 },
                    { 2, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7311), false, "آذربایجان غربی", 2 },
                    { 3, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7314), false, "اردبیل", 3 },
                    { 4, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7316), false, "اصفهان", 4 },
                    { 5, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7318), false, "البرز", 5 },
                    { 6, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7320), false, "ایلام", 6 },
                    { 7, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7322), false, "بوشهر", 7 },
                    { 8, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7324), false, "تهران", 8 },
                    { 9, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7326), false, "چهارمحال و بختیاری", 9 },
                    { 10, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7327), false, "خراسان جنوبی", 10 },
                    { 11, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7329), false, "خراسان رضوی", 11 },
                    { 12, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7331), false, "خراسان شمالی", 12 },
                    { 13, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7333), false, "خوزستان", 13 },
                    { 14, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7335), false, "زنجان", 14 },
                    { 15, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7387), false, "سمنان", 15 },
                    { 16, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7390), false, "سیستان و بلوچستان", 16 },
                    { 17, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7392), false, "فارس", 17 },
                    { 18, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7394), false, "قزوین", 18 },
                    { 19, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7396), false, "قم", 19 },
                    { 20, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7398), false, "کردستان", 20 },
                    { 21, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7400), false, "کرمان", 21 },
                    { 22, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7401), false, "کرمانشاه", 22 },
                    { 23, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7403), false, "کهگیلویه و بویراحمد", 23 },
                    { 24, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7405), false, "گلستان", 24 },
                    { 25, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7408), false, "گیلان", 25 },
                    { 26, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7410), false, "لرستان", 26 },
                    { 27, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7411), false, "مازندران", 27 },
                    { 28, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7413), false, "مرکزی", 28 },
                    { 29, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7415), false, "هرمزگان", 29 },
                    { 30, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7417), false, "همدان", 30 },
                    { 31, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(7419), false, "یزد", 31 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Image", "IsDeleted", "Title", "WorkExperience" },
                values: new object[] { 1, 1, new DateTime(2024, 4, 30, 7, 52, 23, 838, DateTimeKind.Local).AddTicks(434), "", "", false, "کاشی و سرامیک", 0 });

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
