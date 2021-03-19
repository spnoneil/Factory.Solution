using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class Update_Engineer_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HourlyRate",
                table: "Engineers",
                newName: "Salary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Engineers",
                newName: "HourlyRate");
        }
    }
}
