using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class addPersonalTests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationPhases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPhases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Insitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPlatform",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPlatform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Compensation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalTestInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disability = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalTestInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalTestInfos_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobPlatformHelper",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobID = table.Column<int>(type: "int", nullable: false),
                    JobPlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPlatformHelper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobPlatformHelper_JobPlatform_JobPlatformId",
                        column: x => x.JobPlatformId,
                        principalTable: "JobPlatform",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobPlatformHelper_Jobs_JobID",
                        column: x => x.JobID,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobTypeHelpers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobID = table.Column<int>(type: "int", nullable: false),
                    JobTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypeHelpers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTypeHelpers_Jobs_JobID",
                        column: x => x.JobID,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTypeHelpers_JobTypes_JobTypeID",
                        column: x => x.JobTypeID,
                        principalTable: "JobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GitHubLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedInLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalInformations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TimeApplied = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DocumentHelpers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentHelpers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentHelpers_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationHelpers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    EducationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationHelpers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationHelpers_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginHelpers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeDateLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeDateLogOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHelpers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disability = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalInformations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegisterHelpers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeDateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterHelpers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisterHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistoryHelpers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    WorkHistoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistoryHelpers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkHistoryHelpers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkHistoryHelpers_WorkHistories_WorkHistoryId",
                        column: x => x.WorkHistoryId,
                        principalTable: "WorkHistories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationPhasesHelpers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    ApplicationPhaseId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    TimeMoved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPhasesHelpers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationPhasesHelpers_ApplicationPhases_ApplicationPhaseId",
                        column: x => x.ApplicationPhaseId,
                        principalTable: "ApplicationPhases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationPhasesHelpers_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationPhases",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Phone Screen" },
                    { 2, "First Interview" },
                    { 3, "Second Interview" },
                    { 4, "CEO Final Interview" },
                    { 5, "Offer Sent" }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "Id", "DocumentName", "DocumentUrl" },
                values: new object[,]
                {
                    { 1, "CV", "https://johnsnowsociety.org" },
                    { 2, "Drivers license", "https://johnsnowdrivers.com" }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "EndDate", "Insitution", "Qualification", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 21, 10, 20, 14, 151, DateTimeKind.Local).AddTicks(4952), "Richmond", "BSc Computer Science", new DateTime(2021, 10, 21, 10, 20, 16, 151, DateTimeKind.Local).AddTicks(4549) },
                    { 2, new DateTime(2022, 12, 21, 10, 20, 14, 151, DateTimeKind.Local).AddTicks(5619), "Hogwarts", "HighSchool Diploma", new DateTime(2021, 10, 21, 10, 22, 14, 151, DateTimeKind.Local).AddTicks(5613) }
                });

            migrationBuilder.InsertData(
                table: "JobPlatform",
                columns: new[] { "Id", "PlatformName" },
                values: new object[,]
                {
                    { 3, "Twitter" },
                    { 2, "Indeed" },
                    { 1, "LinkedIn" }
                });

            migrationBuilder.InsertData(
                table: "JobTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { 1, "Full-Time" },
                    { 2, "Part-Time" },
                    { 3, "Internship" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Compensation", "CreationDate", "Department", "Description", "DueDate", "Location", "Title" },
                values: new object[,]
                {
                    { 2, "R50000", new DateTime(2021, 10, 21, 10, 20, 14, 146, DateTimeKind.Local).AddTicks(7704), "IT", "beep! beep beep!", new DateTime(2021, 11, 21, 10, 20, 14, 146, DateTimeKind.Local).AddTicks(7687), "DBN", "Mobile Administrator" },
                    { 1, "R45000", new DateTime(2021, 10, 21, 10, 20, 14, 146, DateTimeKind.Local).AddTicks(7148), "IT", "blah! blah! blah!", new DateTime(2021, 12, 21, 10, 20, 14, 145, DateTimeKind.Local).AddTicks(3753), "JHB", "Developer" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "In Progress" },
                    { 2, "Regreted" },
                    { 3, "Hired" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, "sample@gmail.com", "2526sgfgfhsgdf984894s", "Candidate" },
                    { 2, "analyst@test.com", "1538sgligrand9845sds", "Analyst" }
                });

            migrationBuilder.InsertData(
                table: "WorkHistories",
                columns: new[] { "Id", "CompanyName", "Description", "EndDate", "JobTitle", "StartDate" },
                values: new object[,]
                {
                    { 1, "White Wolf Inc", "Commanded an army to victory", new DateTime(2023, 10, 21, 10, 20, 14, 153, DateTimeKind.Local).AddTicks(3588), "Commander", new DateTime(2021, 10, 21, 10, 20, 14, 153, DateTimeKind.Local).AddTicks(3195) },
                    { 2, "Westeros Pty Ltd", "Daydreaming on a Sunday afternoon", new DateTime(2024, 10, 21, 10, 20, 14, 153, DateTimeKind.Local).AddTicks(4633), "King", new DateTime(2022, 10, 21, 10, 20, 14, 153, DateTimeKind.Local).AddTicks(4624) }
                });

            migrationBuilder.InsertData(
                table: "AdditionalInformations",
                columns: new[] { "Id", "FacebookLink", "GitHubLink", "LinkedInLink", "PersonalWebsiteUrl", "UserId" },
                values: new object[] { 1, null, "https://github.com/johnsnowwygot", "https://linkedIn.com/snowy", "https://jphnsnow.com ", 1 });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "JobId", "TimeApplied", "UserId" },
                values: new object[] { 1, 1, new DateTime(2021, 10, 21, 10, 22, 14, 149, DateTimeKind.Local).AddTicks(3156), 1 });

            migrationBuilder.InsertData(
                table: "DocumentHelpers",
                columns: new[] { "Id", "DocumentId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "EducationHelpers",
                columns: new[] { "Id", "EducationId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "JobPlatformHelper",
                columns: new[] { "Id", "JobID", "JobPlatformId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "JobTypeHelpers",
                columns: new[] { "Id", "JobID", "JobTypeID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "PersonalInformations",
                columns: new[] { "Id", "Address", "Disability", "Email", "Ethnicity", "FirstName", "Gender", "IdNumber", "LastName", "PhoneNumber", "UserId" },
                values: new object[] { 1, "2 Winter Fell Road", false, null, "Wildling", "John", "male", "74102589631", "Snow", "0329434578", 1 });

            migrationBuilder.InsertData(
                table: "WorkHistoryHelpers",
                columns: new[] { "Id", "UserId", "WorkHistoryId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "ApplicationPhasesHelpers",
                columns: new[] { "Id", "ApplicationId", "ApplicationPhaseId", "Comments", "PhaseId", "StatusId", "TimeMoved" },
                values: new object[] { 1, 1, null, "Good Candidate, has potential to rule all of Westeros", 1, 1, new DateTime(2021, 10, 21, 10, 20, 14, 150, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.InsertData(
                table: "ApplicationPhasesHelpers",
                columns: new[] { "Id", "ApplicationId", "ApplicationPhaseId", "Comments", "PhaseId", "StatusId", "TimeMoved" },
                values: new object[] { 2, 1, null, "Interview went well, He's really got potential", 2, 1, new DateTime(2021, 10, 23, 10, 20, 14, 150, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.InsertData(
                table: "ApplicationPhasesHelpers",
                columns: new[] { "Id", "ApplicationId", "ApplicationPhaseId", "Comments", "PhaseId", "StatusId", "TimeMoved" },
                values: new object[] { 3, 1, null, "He's good, but won't become king", 3, 2, new DateTime(2021, 12, 21, 10, 20, 14, 150, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalInformations_UserId",
                table: "AdditionalInformations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationPhasesHelpers_ApplicationId",
                table: "ApplicationPhasesHelpers",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationPhasesHelpers_ApplicationPhaseId",
                table: "ApplicationPhasesHelpers",
                column: "ApplicationPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_JobId",
                table: "Applications",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentHelpers_DocumentId",
                table: "DocumentHelpers",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentHelpers_UserId",
                table: "DocumentHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationHelpers_EducationId",
                table: "EducationHelpers",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationHelpers_UserId",
                table: "EducationHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_JobPlatformHelper_JobID",
                table: "JobPlatformHelper",
                column: "JobID");

            migrationBuilder.CreateIndex(
                name: "IX_JobPlatformHelper_JobPlatformId",
                table: "JobPlatformHelper",
                column: "JobPlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTypeHelpers_JobID",
                table: "JobTypeHelpers",
                column: "JobID");

            migrationBuilder.CreateIndex(
                name: "IX_JobTypeHelpers_JobTypeID",
                table: "JobTypeHelpers",
                column: "JobTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LoginHelpers_UserId",
                table: "LoginHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformations_UserId",
                table: "PersonalInformations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalTestInfos_AppUserId",
                table: "PersonalTestInfos",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisterHelpers_UserId",
                table: "RegisterHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistoryHelpers_UserId",
                table: "WorkHistoryHelpers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistoryHelpers_WorkHistoryId",
                table: "WorkHistoryHelpers",
                column: "WorkHistoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalInformations");

            migrationBuilder.DropTable(
                name: "ApplicationPhasesHelpers");

            migrationBuilder.DropTable(
                name: "DocumentHelpers");

            migrationBuilder.DropTable(
                name: "EducationHelpers");

            migrationBuilder.DropTable(
                name: "JobPlatformHelper");

            migrationBuilder.DropTable(
                name: "JobTypeHelpers");

            migrationBuilder.DropTable(
                name: "LoginHelpers");

            migrationBuilder.DropTable(
                name: "PersonalInformations");

            migrationBuilder.DropTable(
                name: "PersonalTestInfos");

            migrationBuilder.DropTable(
                name: "RegisterHelpers");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "WorkHistoryHelpers");

            migrationBuilder.DropTable(
                name: "ApplicationPhases");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "JobPlatform");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "WorkHistories");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
