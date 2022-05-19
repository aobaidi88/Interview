using Microsoft.EntityFrameworkCore.Migrations;

namespace AObaidiP5.Server.Migrations
{
    public partial class CreatingBoardDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SnowBoardstb",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncludeBindings = table.Column<bool>(type: "bit", nullable: false),
                    IsRegularFoot = table.Column<bool>(type: "bit", nullable: false),
                    Lenght = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    BindingOption = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SnowBoardstb", x => x.OrderId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SnowBoardstb");
        }
    }
}
