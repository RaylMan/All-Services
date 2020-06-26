using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllServicesData.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Access",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Access_Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Acceess_Id = table.Column<int>(nullable: false),
                    Telephone = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Access",
                        column: x => x.Acceess_Id,
                        principalTable: "Access",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ServiceType_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceType_EquipmentTypes",
                        column: x => x.ServiceType_Id,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RepairCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Service_Type_Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairCategories_ServiceType",
                        column: x => x.Service_Type_Id,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    LogoUrl = table.Column<string>(nullable: true),
                    WebSiteUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false, defaultValue: "0"),
                    SmallDescription = table.Column<string>(nullable: false),
                    Popularity = table.Column<int>(nullable: false),
                    Likes = table.Column<int>(nullable: false, defaultValue: 0),
                    Dislikes = table.Column<int>(nullable: false, defaultValue: 0),
                    AccessId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Access_AccessId",
                        column: x => x.AccessId,
                        principalTable: "Access",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_User",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    EquipmentType_Id = table.Column<int>(nullable: false),
                    Manufacturer_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_EquipmentTypes",
                        column: x => x.EquipmentType_Id,
                        principalTable: "EquipmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipments_Manufacturers",
                        column: x => x.Manufacturer_Id,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Company_Id = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyAddress",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Image_Id = table.Column<int>(nullable: false),
                    Company_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_CompanyImage",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Image_CompanyImage",
                        column: x => x.Image_Id,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Telephone = table.Column<string>(maxLength: 30, nullable: false),
                    Company_Id = table.Column<int>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telephones_Company",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Access",
                columns: new[] { "Id", "Access_Name" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "Access",
                columns: new[] { "Id", "Access_Name" },
                values: new object[] { 2, "User" });

            migrationBuilder.InsertData(
                table: "Access",
                columns: new[] { "Id", "Access_Name" },
                values: new object[] { 3, "Company" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Acceess_Id", "Adress", "Email", "FirstName", "LastName", "PasswordHash", "Telephone", "Token" },
                values: new object[] { 1, 1, "admin", "admin", "admin", "admin", "admin", "admin", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Acceess_Id", "Adress", "Email", "FirstName", "LastName", "PasswordHash", "Telephone", "Token" },
                values: new object[] { 2, 2, "user", "user", "user", "user", "user", "user", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Acceess_Id", "Adress", "Email", "FirstName", "LastName", "PasswordHash", "Telephone", "Token" },
                values: new object[] { 3, 3, "company", "company", "company", "company", "company", "company", null });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AccessId",
                table: "Companies",
                column: "AccessId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_User_Id",
                table: "Companies",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddresses_Company_Id",
                table: "CompanyAddresses",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyImages_Company_Id",
                table: "CompanyImages",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyImages_Image_Id",
                table: "CompanyImages",
                column: "Image_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentType_Id",
                table: "Equipment",
                column: "EquipmentType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_Manufacturer_Id",
                table: "Equipment",
                column: "Manufacturer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentTypes_ServiceType_Id",
                table: "EquipmentTypes",
                column: "ServiceType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepairCategories_Service_Type_Id",
                table: "RepairCategories",
                column: "Service_Type_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_Company_Id",
                table: "Telephones",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Acceess_Id",
                table: "Users",
                column: "Acceess_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyAddresses");

            migrationBuilder.DropTable(
                name: "CompanyImages");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "RepairCategories");

            migrationBuilder.DropTable(
                name: "Telephones");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "EquipmentTypes");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Access");
        }
    }
}
