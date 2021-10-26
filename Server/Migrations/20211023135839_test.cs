using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Disability",
                table: "PersonalTestInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 23, 15, 58, 37, 211, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeMoved",
                value: new DateTime(2021, 10, 25, 15, 58, 37, 211, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "ApplicationPhasesHelpers",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeMoved",
                value: new DateTime(2021, 12, 23, 15, 58, 37, 211, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeApplied",
                value: new DateTime(2021, 10, 23, 16, 0, 37, 207, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 12, 23, 15, 58, 37, 213, DateTimeKind.Local).AddTicks(495), new DateTime(2021, 10, 23, 15, 58, 39, 212, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2022, 12, 23, 15, 58, 37, 213, DateTimeKind.Local).AddTicks(1701), new DateTime(2021, 10, 23, 16, 0, 37, 213, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 23, 15, 58, 37, 202, DateTimeKind.Local).AddTicks(6669), new DateTime(2021, 12, 23, 15, 58, 37, 201, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "DueDate" },
                values: new object[] { new DateTime(2021, 10, 23, 15, 58, 37, 202, DateTimeKind.Local).AddTicks(7371), new DateTime(2021, 11, 23, 15, 58, 37, 202, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 23, 15, 58, 37, 216, DateTimeKind.Local).AddTicks(6305), new DateTime(2021, 10, 23, 15, 58, 37, 216, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "WorkHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 10, 23, 15, 58, 37, 216, DateTimeKind.Local).AddTicks(8345), new DateTime(2022, 10, 23, 15, 58, 37, 216, DateTimeKind.Local).AddTicks(8331) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Disability",
                table: "PersonalTestInfos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
