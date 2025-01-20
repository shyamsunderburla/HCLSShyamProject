using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HCLSPro.Migrations
{
    /// <inheritdoc />
    public partial class employeetablescreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_ AdminTypes_AdminTypeId",
                table: "Admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ AdminTypes",
                table: " AdminTypes");

            migrationBuilder.RenameTable(
                name: " AdminTypes",
                newName: "AdminTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminTypes",
                table: "AdminTypes",
                column: "AdminTypeId");

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DeptNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    DName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DeptNo);
                });

            migrationBuilder.CreateTable(
                name: "DoctorSpecialization",
                columns: table => new
                {
                    DocSpecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecialization", x => x.DocSpecId);
                });

            migrationBuilder.CreateTable(
                name: "HelperDetails",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logged = table.Column<bool>(type: "bit", nullable: false),
                    Assigned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelperDetails", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "LabDetails",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logged = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabDetails", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionistDetails",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logged = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionistDetails", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DOJ = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DeptNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DeptNo",
                        column: x => x.DeptNo,
                        principalTable: "Department",
                        principalColumn: "DeptNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorDetails",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logged = table.Column<bool>(type: "bit", nullable: false),
                    Assigned = table.Column<bool>(type: "bit", nullable: false),
                    DocSpecId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorDetails", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_DoctorDetails_DoctorSpecialization_DocSpecId",
                        column: x => x.DocSpecId,
                        principalTable: "DoctorSpecialization",
                        principalColumn: "DocSpecId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorDetails_DocSpecId",
                table: "DoctorDetails",
                column: "DocSpecId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DeptNo",
                table: "Employee",
                column: "DeptNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_AdminTypes_AdminTypeId",
                table: "Admin",
                column: "AdminTypeId",
                principalTable: "AdminTypes",
                principalColumn: "AdminTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_AdminTypes_AdminTypeId",
                table: "Admin");

            migrationBuilder.DropTable(
                name: "DoctorDetails");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "HelperDetails");

            migrationBuilder.DropTable(
                name: "LabDetails");

            migrationBuilder.DropTable(
                name: "ReceptionistDetails");

            migrationBuilder.DropTable(
                name: "DoctorSpecialization");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminTypes",
                table: "AdminTypes");

            migrationBuilder.RenameTable(
                name: "AdminTypes",
                newName: " AdminTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ AdminTypes",
                table: " AdminTypes",
                column: "AdminTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_ AdminTypes_AdminTypeId",
                table: "Admin",
                column: "AdminTypeId",
                principalTable: " AdminTypes",
                principalColumn: "AdminTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
