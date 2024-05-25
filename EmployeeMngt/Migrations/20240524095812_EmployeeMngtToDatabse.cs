using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeMngt.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeMngtToDatabse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Employeeid = table.Column<Guid>(name: "Employee_id", type: "uniqueidentifier", nullable: false),
                    Employeename = table.Column<string>(name: "Employee_name", type: "nvarchar(max)", nullable: false),
                    Employeegender = table.Column<string>(name: "Employee_gender", type: "nvarchar(max)", nullable: false),
                    Employeephone = table.Column<string>(name: "Employee_phone", type: "nvarchar(max)", nullable: false),
                    Employeeemail = table.Column<string>(name: "Employee_email", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Employeeid);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AdressId = table.Column<int>(name: "Adress_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employeecity = table.Column<string>(name: "Employee_city", type: "nvarchar(max)", nullable: false),
                    Employeezipcode = table.Column<string>(name: "Employee_zipcode", type: "nvarchar(max)", nullable: false),
                    Employeestate = table.Column<string>(name: "Employee_state", type: "nvarchar(max)", nullable: false),
                    Employeecountry = table.Column<string>(name: "Employee_country", type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(name: "Employee_Id", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AdressId);
                    table.ForeignKey(
                        name: "FK_Address_Employee_Employee_Id",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Employee_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(name: "Employee_Id", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Department_Employee_Employee_Id",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Employee_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_Employee_Id",
                table: "Address",
                column: "Employee_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_Employee_Id",
                table: "Department",
                column: "Employee_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
