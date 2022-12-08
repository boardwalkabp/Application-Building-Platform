using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UserAndClientRoleColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "User");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "clients",
                type: "text",
                nullable: false,
                defaultValue: "Client");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "clients");
        }
    }
}
