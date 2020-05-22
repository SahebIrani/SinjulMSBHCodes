using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5Preview.Migrations
{
    public partial class InitPreview4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Numeric",
                table: "Shop",
                type: "decimal(17,4)",
                precision: 17,
                scale: 4,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FullName",
                table: "Customers",
                column: "FullName")
                .Annotation("SqlServer:FillFactor", 90);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FullName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Numeric",
                table: "Shop");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
