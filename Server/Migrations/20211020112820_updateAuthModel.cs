using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class updateAuthModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 20, 13, 28, 18, 360, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 22, 13, 28, 18, 360, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeMoved",
                value: new DateTime(2021, 12, 20, 13, 28, 18, 360, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeApplied",
                value: new DateTime(2021, 10, 20, 13, 30, 18, 358, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 20, 13, 28, 18, 361, DateTimeKind.Local).AddTicks(7252), new DateTime(2021, 10, 20, 13, 28, 20, 361, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 20, 13, 28, 18, 361, DateTimeKind.Local).AddTicks(8488), new DateTime(2021, 10, 20, 13, 30, 18, 361, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 20, 13, 28, 18, 354, DateTimeKind.Local).AddTicks(1433), new DateTime(2021, 12, 20, 13, 28, 18, 352, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 20, 13, 28, 18, 354, DateTimeKind.Local).AddTicks(2161), new DateTime(2021, 11, 20, 13, 28, 18, 354, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 20, 13, 28, 18, 364, DateTimeKind.Local).AddTicks(3761), new DateTime(2021, 10, 20, 13, 28, 18, 364, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 20, 13, 28, 18, 364, DateTimeKind.Local).AddTicks(4804), new DateTime(2022, 10, 20, 13, 28, 18, 364, DateTimeKind.Local).AddTicks(4796) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
