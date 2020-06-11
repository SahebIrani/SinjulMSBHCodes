using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5Preview.Migrations
{
    public partial class UpdatedToPreview5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                collation: "Persian_PhoneBook");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true,
                collation: "Persian_PhoneBook",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SomethingComputed",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "my sql",
                computedColumnIsStored: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SomethingComputed",
                table: "Customers");

            migrationBuilder.AlterDatabase(collation: "Persian_PhoneBook",
                oldCollation: "Persian_PhoneBook");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldCollation: "Persian_PhoneBook");
        }
    }
}
