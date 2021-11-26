using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterColumn<decimal>(
            //    name: "ExpectedSalary",
            //    table: "Questionnaires",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(double),
            //    oldType: "float");

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "EndDate",
            //    table: "Questionnaires",
            //    type: "datetime2",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AlterColumn<decimal>(
            //    name: "ExpectedSalary",
            //    table: "IdealCandidates",
            //    type: "decimal(18,2)",
            //    nullable: false,
            //    oldClrType: typeof(double),
            //    oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Questionnaires");

            migrationBuilder.AlterColumn<double>(
                name: "ExpectedSalary",
                table: "Questionnaires",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "ExpectedSalary",
                table: "IdealCandidates",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
