using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Experiment4.Migrations
{
    public partial class inital6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CYCompany",
                columns: table => new
                {
                    CYId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CreditCode = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    FirmPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CYCompany", x => x.CYId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Phone = table.Column<string>(nullable: false),
                    IdCard = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Phone);
                });

            migrationBuilder.CreateTable(
                name: "FhCompany",
                columns: table => new
                {
                    FhId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FirmPhone = table.Column<string>(nullable: true),
                    CreditCode = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FhCompany", x => x.FhId);
                });

            migrationBuilder.CreateTable(
                name: "TZF",
                columns: table => new
                {
                    TZFId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TZFPhone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TZF", x => x.TZFId);
                });

            migrationBuilder.CreateTable(
                name: "CYManagement",
                columns: table => new
                {
                    CYNumber = table.Column<Guid>(nullable: false),
                    CYId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CYManagement", x => x.CYNumber);
                    table.ForeignKey(
                        name: "FK_CYManagement_CYCompany_CYId",
                        column: x => x.CYId,
                        principalTable: "CYCompany",
                        principalColumn: "CYId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CYManagement_Employee_Phone",
                        column: x => x.Phone,
                        principalTable: "Employee",
                        principalColumn: "Phone",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FHManagement",
                columns: table => new
                {
                    FHNumber = table.Column<Guid>(nullable: false),
                    HFId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    FhId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FHManagement", x => x.FHNumber);
                    table.ForeignKey(
                        name: "FK_FHManagement_FhCompany_FhId",
                        column: x => x.FhId,
                        principalTable: "FhCompany",
                        principalColumn: "FhId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FHManagement_Employee_Phone",
                        column: x => x.Phone,
                        principalTable: "Employee",
                        principalColumn: "Phone",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(nullable: true),
                    CYId = table.Column<int>(nullable: false),
                    TZFId = table.Column<int>(nullable: false),
                    ProjectName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Project_CYCompany_CYId",
                        column: x => x.CYId,
                        principalTable: "CYCompany",
                        principalColumn: "CYId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Project_Employee_Phone",
                        column: x => x.Phone,
                        principalTable: "Employee",
                        principalColumn: "Phone",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_TZF_TZFId",
                        column: x => x.TZFId,
                        principalTable: "TZF",
                        principalColumn: "TZFId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CYManagement_CYId",
                table: "CYManagement",
                column: "CYId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CYManagement_Phone",
                table: "CYManagement",
                column: "Phone");

            migrationBuilder.CreateIndex(
                name: "IX_FHManagement_FhId",
                table: "FHManagement",
                column: "FhId");

            migrationBuilder.CreateIndex(
                name: "IX_FHManagement_Phone",
                table: "FHManagement",
                column: "Phone");

            migrationBuilder.CreateIndex(
                name: "IX_Project_CYId",
                table: "Project",
                column: "CYId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_Phone",
                table: "Project",
                column: "Phone",
                unique: true,
                filter: "[Phone] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Project_TZFId",
                table: "Project",
                column: "TZFId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CYManagement");

            migrationBuilder.DropTable(
                name: "FHManagement");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "FhCompany");

            migrationBuilder.DropTable(
                name: "CYCompany");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "TZF");
        }
    }
}
