using Microsoft.EntityFrameworkCore.Migrations;

namespace AObaidiP5.Server.Migrations
{
    public partial class NewCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Images",
                table: "SnowBoardstb",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                table: "SnowBoardstb");
        }
    }
}
