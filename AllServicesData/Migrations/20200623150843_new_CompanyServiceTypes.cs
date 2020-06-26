using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllServicesData.Migrations
{
    public partial class new_CompanyServiceTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    Company_Id = table.Column<int>(nullable: false),
                    Service_Type_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyServiceTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyServiceTypes_Service_Type",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyServiceTypes_User",
                        column: x => x.Service_Type_Id,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "Path" },
                values: new object[] { 1, "All-Service_default-image.jpg", "/Images/All-Service_default-image.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServiceTypes_Company_Id",
                table: "CompanyServiceTypes",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServiceTypes_Service_Type_Id",
                table: "CompanyServiceTypes",
                column: "Service_Type_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyServiceTypes");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
