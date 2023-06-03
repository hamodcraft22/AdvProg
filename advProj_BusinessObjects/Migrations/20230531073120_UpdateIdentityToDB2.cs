using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace advProj_BusinessObjects.Migrations
{
    public partial class UpdateIdentityToDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userID",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }
    }
}
