using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class platformtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPlatformHelper_JobPlatform_JobPlatformId",
                table: "JobPlatformHelper");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPlatformHelper_Jobs_JobID",
                table: "JobPlatformHelper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPlatformHelper",
                table: "JobPlatformHelper");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPlatform",
                table: "JobPlatform");

            migrationBuilder.RenameTable(
                name: "JobPlatformHelper",
                newName: "JobPlatformHelpers");

            migrationBuilder.RenameTable(
                name: "JobPlatform",
                newName: "JobPlatforms");

            migrationBuilder.RenameIndex(
                name: "IX_JobPlatformHelper_JobPlatformId",
                table: "JobPlatformHelpers",
                newName: "IX_JobPlatformHelpers_JobPlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPlatformHelper_JobID",
                table: "JobPlatformHelpers",
                newName: "IX_JobPlatformHelpers_JobID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPlatformHelpers",
                table: "JobPlatformHelpers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPlatforms",
                table: "JobPlatforms",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 18, 10, 9, 10, 576, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 20, 10, 9, 10, 576, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeMoved",
                value: new DateTime(2021, 12, 18, 10, 9, 10, 576, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeApplied",
                value: new DateTime(2021, 10, 18, 10, 11, 10, 572, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 18, 10, 9, 10, 577, DateTimeKind.Local).AddTicks(7637), new DateTime(2021, 10, 18, 10, 9, 12, 577, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 18, 10, 9, 10, 577, DateTimeKind.Local).AddTicks(9471), new DateTime(2021, 10, 18, 10, 11, 10, 577, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 18, 10, 9, 10, 566, DateTimeKind.Local).AddTicks(818), new DateTime(2021, 12, 18, 10, 9, 10, 564, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 18, 10, 9, 10, 566, DateTimeKind.Local).AddTicks(1718), new DateTime(2021, 11, 18, 10, 9, 10, 566, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 10, 9, 10, 582, DateTimeKind.Local).AddTicks(5945), new DateTime(2021, 10, 18, 10, 9, 10, 582, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 18, 10, 9, 10, 582, DateTimeKind.Local).AddTicks(8191), new DateTime(2022, 10, 18, 10, 9, 10, 582, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.AddForeignKey(
                name: "FK_JobPlatformHelpers_JobPlatforms_JobPlatformId",
                table: "JobPlatformHelpers",
                column: "JobPlatformId",
                principalTable: "JobPlatforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPlatformHelpers_Jobs_JobID",
                table: "JobPlatformHelpers",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPlatformHelpers_JobPlatforms_JobPlatformId",
                table: "JobPlatformHelpers");

            migrationBuilder.DropForeignKey(
                name: "FK_JobPlatformHelpers_Jobs_JobID",
                table: "JobPlatformHelpers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPlatforms",
                table: "JobPlatforms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPlatformHelpers",
                table: "JobPlatformHelpers");

            migrationBuilder.RenameTable(
                name: "JobPlatforms",
                newName: "JobPlatform");

            migrationBuilder.RenameTable(
                name: "JobPlatformHelpers",
                newName: "JobPlatformHelper");

            migrationBuilder.RenameIndex(
                name: "IX_JobPlatformHelpers_JobPlatformId",
                table: "JobPlatformHelper",
                newName: "IX_JobPlatformHelper_JobPlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_JobPlatformHelpers_JobID",
                table: "JobPlatformHelper",
                newName: "IX_JobPlatformHelper_JobID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPlatform",
                table: "JobPlatform",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPlatformHelper",
                table: "JobPlatformHelper",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 12, 13, 7, 20, 384, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 14, 13, 7, 20, 384, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeMoved",
                value: new DateTime(2021, 12, 12, 13, 7, 20, 384, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeApplied",
                value: new DateTime(2021, 10, 12, 13, 9, 20, 381, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 12, 13, 7, 20, 386, DateTimeKind.Local).AddTicks(7269), new DateTime(2021, 10, 12, 13, 7, 22, 386, DateTimeKind.Local).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 12, 13, 7, 20, 387, DateTimeKind.Local).AddTicks(173), new DateTime(2021, 10, 12, 13, 9, 20, 387, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 12, 13, 7, 20, 376, DateTimeKind.Local).AddTicks(9064), new DateTime(2021, 12, 12, 13, 7, 20, 374, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 12, 13, 7, 20, 377, DateTimeKind.Local).AddTicks(224), new DateTime(2021, 11, 12, 13, 7, 20, 377, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 12, 13, 7, 20, 390, DateTimeKind.Local).AddTicks(3384), new DateTime(2021, 10, 12, 13, 7, 20, 390, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 12, 13, 7, 20, 390, DateTimeKind.Local).AddTicks(6971), new DateTime(2022, 10, 12, 13, 7, 20, 390, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.AddForeignKey(
                name: "FK_JobPlatformHelper_JobPlatform_JobPlatformId",
                table: "JobPlatformHelper",
                column: "JobPlatformId",
                principalTable: "JobPlatform",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobPlatformHelper_Jobs_JobID",
                table: "JobPlatformHelper",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
