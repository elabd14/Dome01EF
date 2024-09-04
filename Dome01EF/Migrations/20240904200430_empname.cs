using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dome01EF.Migrations
{
    public partial class empname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "EmpName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpName",
                table: "Employees",
                newName: "Name");
        }
    }
}
