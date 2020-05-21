using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceApp.Data.Migrations
{
    public partial class addedFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PdfUrl",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BackImage",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrontImage",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PdfUrl",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "BackImage",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FrontImage",
                table: "Cars");
        }
    }
}
