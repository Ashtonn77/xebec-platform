using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class MzwandileMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_IdealCandidates_Citizenships_CitizenshipId",
            //    table: "IdealCandidates");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_IdealCandidates_JobPlatforms_JobPlatformId",
            //    table: "IdealCandidates");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Questionnaires_Citizenships_CitizenshipId",
            //    table: "Questionnaires");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Questionnaires_JobPlatforms_JobPlatformId",
            //    table: "Questionnaires");

            //migrationBuilder.DropColumn(
            //    name: "CitizenId",
            //    table: "Questionnaires");

            //migrationBuilder.DropColumn(
            //    name: "EndDate",
            //    table: "Questionnaires");

            //migrationBuilder.DropColumn(
            //    name: "PlatformId",
            //    table: "Questionnaires");

            //migrationBuilder.DropColumn(
            //    name: "CitizenId",
            //    table: "IdealCandidates");

            //migrationBuilder.DropColumn(
            //    name: "PlatformId",
            //    table: "IdealCandidates");

            //migrationBuilder.AlterColumn<int>(
            //    name: "JobPlatformId",
            //    table: "Questionnaires",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "CitizenshipId",
            //    table: "Questionnaires",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "JobPlatformId",
            //    table: "IdealCandidates",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "CitizenshipId",
            //    table: "IdealCandidates",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "beginApplication",
            //    table: "Applications",
            //    type: "datetime2",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddForeignKey(
            //    name: "FK_IdealCandidates_Citizenships_CitizenshipId",
            //    table: "IdealCandidates",
            //    column: "CitizenshipId",
            //    principalTable: "Citizenships",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_IdealCandidates_JobPlatforms_JobPlatformId",
            //    table: "IdealCandidates",
            //    column: "JobPlatformId",
            //    principalTable: "JobPlatforms",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Questionnaires_Citizenships_CitizenshipId",
            //    table: "Questionnaires",
            //    column: "CitizenshipId",
            //    principalTable: "Citizenships",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Questionnaires_JobPlatforms_JobPlatformId",
            //    table: "Questionnaires",
            //    column: "JobPlatformId",
            //    principalTable: "JobPlatforms",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdealCandidates_Citizenships_CitizenshipId",
                table: "IdealCandidates");

            migrationBuilder.DropForeignKey(
                name: "FK_IdealCandidates_JobPlatforms_JobPlatformId",
                table: "IdealCandidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Citizenships_CitizenshipId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_JobPlatforms_JobPlatformId",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "beginApplication",
                table: "Applications");

            migrationBuilder.AlterColumn<int>(
                name: "JobPlatformId",
                table: "Questionnaires",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CitizenshipId",
                table: "Questionnaires",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CitizenId",
                table: "Questionnaires",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Questionnaires",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PlatformId",
                table: "Questionnaires",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "JobPlatformId",
                table: "IdealCandidates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CitizenshipId",
                table: "IdealCandidates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CitizenId",
                table: "IdealCandidates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlatformId",
                table: "IdealCandidates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_IdealCandidates_Citizenships_CitizenshipId",
                table: "IdealCandidates",
                column: "CitizenshipId",
                principalTable: "Citizenships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IdealCandidates_JobPlatforms_JobPlatformId",
                table: "IdealCandidates",
                column: "JobPlatformId",
                principalTable: "JobPlatforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Citizenships_CitizenshipId",
                table: "Questionnaires",
                column: "CitizenshipId",
                principalTable: "Citizenships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_JobPlatforms_JobPlatformId",
                table: "Questionnaires",
                column: "JobPlatformId",
                principalTable: "JobPlatforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
