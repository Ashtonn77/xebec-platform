using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class changeDbTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalInformationTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GitHubLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedInLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInformationTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalInformationTests_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Insitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationTests_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistoryTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistoryTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkHistoryTests_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 21, 15, 12, 5, 48, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 23, 15, 12, 5, 49, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeMoved",
                value: new DateTime(2021, 12, 21, 15, 12, 5, 49, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeApplied",
                value: new DateTime(2021, 10, 21, 15, 14, 5, 46, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 21, 15, 12, 5, 50, DateTimeKind.Local).AddTicks(7009), new DateTime(2021, 10, 21, 15, 12, 7, 50, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 15, 12, 5, 50, DateTimeKind.Local).AddTicks(9104), new DateTime(2021, 10, 21, 15, 14, 5, 50, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 21, 15, 12, 5, 43, DateTimeKind.Local).AddTicks(8512), new DateTime(2021, 12, 21, 15, 12, 5, 42, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 21, 15, 12, 5, 43, DateTimeKind.Local).AddTicks(9023), new DateTime(2021, 11, 21, 15, 12, 5, 43, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 21, 15, 12, 5, 55, DateTimeKind.Local).AddTicks(394), new DateTime(2021, 10, 21, 15, 12, 5, 54, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 21, 15, 12, 5, 55, DateTimeKind.Local).AddTicks(1432), new DateTime(2022, 10, 21, 15, 12, 5, 55, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInformationTests_AppUserId",
                table: "AdditionalInformationTests",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationTests_AppUserId",
                table: "EducationTests",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistoryTests_AppUserId",
                table: "WorkHistoryTests",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalInformationTests");

            migrationBuilder.DropTable(
                name: "EducationTests");

            migrationBuilder.DropTable(
                name: "WorkHistoryTests");

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 21, 10, 20, 14, 150, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 23, 10, 20, 14, 150, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeMoved",
                value: new DateTime(2021, 12, 21, 10, 20, 14, 150, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeApplied",
                value: new DateTime(2021, 10, 21, 10, 22, 14, 149, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 21, 10, 20, 14, 151, DateTimeKind.Local).AddTicks(4952), new DateTime(2021, 10, 21, 10, 20, 16, 151, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 21, 10, 20, 14, 151, DateTimeKind.Local).AddTicks(5619), new DateTime(2021, 10, 21, 10, 22, 14, 151, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 21, 10, 20, 14, 146, DateTimeKind.Local).AddTicks(7148), new DateTime(2021, 12, 21, 10, 20, 14, 145, DateTimeKind.Local).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 21, 10, 20, 14, 146, DateTimeKind.Local).AddTicks(7704), new DateTime(2021, 11, 21, 10, 20, 14, 146, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 21, 10, 20, 14, 153, DateTimeKind.Local).AddTicks(3588), new DateTime(2021, 10, 21, 10, 20, 14, 153, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 21, 10, 20, 14, 153, DateTimeKind.Local).AddTicks(4633), new DateTime(2022, 10, 21, 10, 20, 14, 153, DateTimeKind.Local).AddTicks(4624) });
        }
    }
}
