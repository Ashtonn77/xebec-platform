using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfilePortfolioLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GitHub = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    websiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePortfolioLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfilePortfolioLinks_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePortfolioLinks_AppUserId",
                table: "ProfilePortfolioLinks",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfilePortfolioLinks");
        }
    }
}
