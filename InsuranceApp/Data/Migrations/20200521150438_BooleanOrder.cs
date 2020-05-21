using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceApp.Data.Migrations
{
    public partial class BooleanOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PdfSent",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ReminderSent",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PdfSent",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ReminderSent",
                table: "Orders");
        }
    }
}
