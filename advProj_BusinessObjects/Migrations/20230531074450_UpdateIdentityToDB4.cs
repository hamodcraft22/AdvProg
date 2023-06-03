using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace advProj_BusinessObjects.Migrations
{
    public partial class UpdateIdentityToDB4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "lName");

            migrationBuilder.AddColumn<string>(
                name: "fName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "lName",
                table: "AspNetUsers",
                newName: "Name");
        }
    }
}
