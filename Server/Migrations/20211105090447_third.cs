using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disability",
                table: "PersonalInformations");

            migrationBuilder.DropColumn(
                name: "Ethnicity",
                table: "PersonalInformations");

            migrationBuilder.DropColumn(
                name: "FacebookLink",
                table: "AdditionalInformations");

            migrationBuilder.RenameColumn(
                name: "websiteUrl",
                table: "ProfilePortfolioLinks",
                newName: "TwitterLink");

            migrationBuilder.RenameColumn(
                name: "Twitter",
                table: "ProfilePortfolioLinks",
                newName: "PersonalWebsiteUrl");

            migrationBuilder.RenameColumn(
                name: "LinkedIn",
                table: "ProfilePortfolioLinks",
                newName: "LinkedInLink");

            migrationBuilder.RenameColumn(
                name: "GitHub",
                table: "ProfilePortfolioLinks",
                newName: "GitHubLink");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "PersonalInformations",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "PersonalWebsiteUrl",
                table: "AdditionalInformations",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "LinkedInLink",
                table: "AdditionalInformations",
                newName: "Ethnicity");

            migrationBuilder.RenameColumn(
                name: "GitHubLink",
                table: "AdditionalInformations",
                newName: "Disability");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationPhasesHelpers_StatusId",
                table: "ApplicationPhasesHelpers",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationPhasesHelpers_Statuses_StatusId",
                table: "ApplicationPhasesHelpers",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationPhasesHelpers_Statuses_StatusId",
                table: "ApplicationPhasesHelpers");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationPhasesHelpers_StatusId",
                table: "ApplicationPhasesHelpers");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "TwitterLink",
                table: "ProfilePortfolioLinks",
                newName: "websiteUrl");

            migrationBuilder.RenameColumn(
                name: "PersonalWebsiteUrl",
                table: "ProfilePortfolioLinks",
                newName: "Twitter");

            migrationBuilder.RenameColumn(
                name: "LinkedInLink",
                table: "ProfilePortfolioLinks",
                newName: "LinkedIn");

            migrationBuilder.RenameColumn(
                name: "GitHubLink",
                table: "ProfilePortfolioLinks",
                newName: "GitHub");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "PersonalInformations",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "AdditionalInformations",
                newName: "PersonalWebsiteUrl");

            migrationBuilder.RenameColumn(
                name: "Ethnicity",
                table: "AdditionalInformations",
                newName: "LinkedInLink");

            migrationBuilder.RenameColumn(
                name: "Disability",
                table: "AdditionalInformations",
                newName: "GitHubLink");

            migrationBuilder.AddColumn<bool>(
                name: "Disability",
                table: "PersonalInformations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Ethnicity",
                table: "PersonalInformations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookLink",
                table: "AdditionalInformations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
