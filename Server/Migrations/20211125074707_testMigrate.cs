using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XebecPortal.Server.Migrations
{
    public partial class testMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            ////migrationBuilder.CreateTable(
            ////    name: "ApplicationPhases",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_ApplicationPhases", x => x.Id);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "AppUser",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_AppUser", x => x.Id);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "Citizenships",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Citizen = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Citizenships", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Departments",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Departments", x => x.Id);
            //    });

            ////migrationBuilder.CreateTable(
            ////    name: "JobPlatforms",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_JobPlatforms", x => x.Id);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "JobTypes",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_JobTypes", x => x.Id);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "Locations",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Province = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Locations", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "NoticePeriods",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Notice = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_NoticePeriods", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Permissions",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PermissionGranted = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Permissions", x => x.Id);
            //    });

            ////migrationBuilder.CreateTable(
            ////    name: "Statuses",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_Statuses", x => x.Id);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "Visas",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ValidVisa = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Visas", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "WorkPermits",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ValidPermit = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_WorkPermits", x => x.Id);
            //    });

            ////migrationBuilder.CreateTable(
            ////    name: "AdditionalInformations",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Disability = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_AdditionalInformations", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_AdditionalInformations_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "AdditionalInformationTests",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        GitHubLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        LinkedInLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        PersonalWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_AdditionalInformationTests", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_AdditionalInformationTests_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "Documents",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        DocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_Documents", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_Documents_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "Educations",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Insitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_Educations", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_Educations_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "EducationTests",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        Insitution = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_EducationTests", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_EducationTests_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "LoginHelpers",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        TimeDateLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        TimeDateLogOut = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_LoginHelpers", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_LoginHelpers_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "PersonalInformations",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_PersonalInformations", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_PersonalInformations_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "PersonalTestInfos",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Disability = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_PersonalTestInfos", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_PersonalTestInfos_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "ProfilePortfolioLinks",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        GitHubLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        LinkedInLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        TwitterLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        PersonalWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_ProfilePortfolioLinks", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_ProfilePortfolioLinks_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "RegisterHelpers",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        TimeDateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_RegisterHelpers", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_RegisterHelpers_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "WorkHistories",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_WorkHistories", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_WorkHistories_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "WorkHistoryTests",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            ////        StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_WorkHistoryTests", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_WorkHistoryTests_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "Jobs",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: false),
            //        DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Jobs", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Jobs_Departments_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "Departments",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Questionnaires",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ExpectedSalary = table.Column<double>(type: "float", nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        NoticePeriodId = table.Column<int>(type: "int", nullable: false),
            //        LocationId = table.Column<int>(type: "int", nullable: false),
            //        Experience = table.Column<int>(type: "int", nullable: false),
            //        PermissionId = table.Column<int>(type: "int", nullable: false),
            //        CitizenId = table.Column<int>(type: "int", nullable: false),
            //        CitizenshipId = table.Column<int>(type: "int", nullable: true),
            //        VisaId = table.Column<int>(type: "int", nullable: false),
            //        WorkPermitId = table.Column<int>(type: "int", nullable: false),
            //        University = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        PlatformId = table.Column<int>(type: "int", nullable: false),
            //        JobPlatformId = table.Column<int>(type: "int", nullable: true),
            //        AppUserId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Questionnaires", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Questionnaires_AppUser_AppUserId",
            //            column: x => x.AppUserId,
            //            principalTable: "AppUser",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Questionnaires_Citizenships_CitizenshipId",
            //            column: x => x.CitizenshipId,
            //            principalTable: "Citizenships",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Questionnaires_JobPlatforms_JobPlatformId",
            //            column: x => x.JobPlatformId,
            //            principalTable: "JobPlatforms",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Questionnaires_Locations_LocationId",
            //            column: x => x.LocationId,
            //            principalTable: "Locations",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Questionnaires_NoticePeriods_NoticePeriodId",
            //            column: x => x.NoticePeriodId,
            //            principalTable: "NoticePeriods",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Questionnaires_Permissions_PermissionId",
            //            column: x => x.PermissionId,
            //            principalTable: "Permissions",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Questionnaires_Visas_VisaId",
            //            column: x => x.VisaId,
            //            principalTable: "Visas",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Questionnaires_WorkPermits_WorkPermitId",
            //            column: x => x.WorkPermitId,
            //            principalTable: "WorkPermits",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            ////migrationBuilder.CreateTable(
            ////    name: "Applications",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        JobId = table.Column<int>(type: "int", nullable: false),
            ////        AppUserId = table.Column<int>(type: "int", nullable: false),
            ////        TimeApplied = table.Column<DateTime>(type: "datetime2", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_Applications", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_Applications_AppUser_AppUserId",
            ////            column: x => x.AppUserId,
            ////            principalTable: "AppUser",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////        table.ForeignKey(
            ////            name: "FK_Applications_Jobs_JobId",
            ////            column: x => x.JobId,
            ////            principalTable: "Jobs",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "IdealCandidates",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ExpectedSalary = table.Column<double>(type: "float", nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        NoticePeriodId = table.Column<int>(type: "int", nullable: false),
            //        LocationId = table.Column<int>(type: "int", nullable: false),
            //        Experience = table.Column<int>(type: "int", nullable: false),
            //        PermissionId = table.Column<int>(type: "int", nullable: false),
            //        CitizenId = table.Column<int>(type: "int", nullable: false),
            //        CitizenshipId = table.Column<int>(type: "int", nullable: true),
            //        VisaId = table.Column<int>(type: "int", nullable: false),
            //        WorkPermitId = table.Column<int>(type: "int", nullable: false),
            //        University = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PlatformId = table.Column<int>(type: "int", nullable: false),
            //        JobPlatformId = table.Column<int>(type: "int", nullable: true),
            //        JobId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_IdealCandidates", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_IdealCandidates_Citizenships_CitizenshipId",
            //            column: x => x.CitizenshipId,
            //            principalTable: "Citizenships",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_IdealCandidates_JobPlatforms_JobPlatformId",
            //            column: x => x.JobPlatformId,
            //            principalTable: "JobPlatforms",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_IdealCandidates_Jobs_JobId",
            //            column: x => x.JobId,
            //            principalTable: "Jobs",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_IdealCandidates_Locations_LocationId",
            //            column: x => x.LocationId,
            //            principalTable: "Locations",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_IdealCandidates_NoticePeriods_NoticePeriodId",
            //            column: x => x.NoticePeriodId,
            //            principalTable: "NoticePeriods",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_IdealCandidates_Permissions_PermissionId",
            //            column: x => x.PermissionId,
            //            principalTable: "Permissions",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_IdealCandidates_Visas_VisaId",
            //            column: x => x.VisaId,
            //            principalTable: "Visas",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_IdealCandidates_WorkPermits_WorkPermitId",
            //            column: x => x.WorkPermitId,
            //            principalTable: "WorkPermits",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            ////migrationBuilder.CreateTable(
            ////    name: "JobPlatformHelpers",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        JobID = table.Column<int>(type: "int", nullable: false),
            ////        JobPlatformId = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_JobPlatformHelpers", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_JobPlatformHelpers_JobPlatforms_JobPlatformId",
            ////            column: x => x.JobPlatformId,
            ////            principalTable: "JobPlatforms",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////        table.ForeignKey(
            ////            name: "FK_JobPlatformHelpers_Jobs_JobID",
            ////            column: x => x.JobID,
            ////            principalTable: "Jobs",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateTable(
            ////    name: "JobTypeHelpers",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        JobID = table.Column<int>(type: "int", nullable: false),
            ////        JobTypeID = table.Column<int>(type: "int", nullable: false)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_JobTypeHelpers", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_JobTypeHelpers_Jobs_JobID",
            ////            column: x => x.JobID,
            ////            principalTable: "Jobs",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////        table.ForeignKey(
            ////            name: "FK_JobTypeHelpers_JobTypes_JobTypeID",
            ////            column: x => x.JobTypeID,
            ////            principalTable: "JobTypes",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            //migrationBuilder.CreateTable(
            //    name: "Results",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ExpectedSalary = table.Column<float>(type: "real", nullable: false),
            //        StartDate = table.Column<float>(type: "real", nullable: false),
            //        NoticePeriodId = table.Column<float>(type: "real", nullable: false),
            //        LocationId = table.Column<float>(type: "real", nullable: false),
            //        Experience = table.Column<float>(type: "real", nullable: false),
            //        PermissionId = table.Column<float>(type: "real", nullable: false),
            //        CitizenId = table.Column<float>(type: "real", nullable: false),
            //        VisaId = table.Column<float>(type: "real", nullable: false),
            //        WorkPermitId = table.Column<float>(type: "real", nullable: false),
            //        University = table.Column<float>(type: "real", nullable: false),
            //        PlatformId = table.Column<float>(type: "real", nullable: false),
            //        AppUserId = table.Column<int>(type: "int", nullable: false),
            //        JobId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Results", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Results_AppUser_AppUserId",
            //            column: x => x.AppUserId,
            //            principalTable: "AppUser",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Results_Jobs_JobId",
            //            column: x => x.JobId,
            //            principalTable: "Jobs",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            ////migrationBuilder.CreateTable(
            ////    name: "ApplicationPhasesHelpers",
            ////    columns: table => new
            ////    {
            ////        Id = table.Column<int>(type: "int", nullable: false)
            ////            .Annotation("SqlServer:Identity", "1, 1"),
            ////        ApplicationId = table.Column<int>(type: "int", nullable: false),
            ////        ApplicationPhaseId = table.Column<int>(type: "int", nullable: false),
            ////        StatusId = table.Column<int>(type: "int", nullable: false),
            ////        TimeMoved = table.Column<DateTime>(type: "datetime2", nullable: false),
            ////        Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
            ////    },
            ////    constraints: table =>
            ////    {
            ////        table.PrimaryKey("PK_ApplicationPhasesHelpers", x => x.Id);
            ////        table.ForeignKey(
            ////            name: "FK_ApplicationPhasesHelpers_ApplicationPhases_ApplicationPhaseId",
            ////            column: x => x.ApplicationPhaseId,
            ////            principalTable: "ApplicationPhases",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////        table.ForeignKey(
            ////            name: "FK_ApplicationPhasesHelpers_Applications_ApplicationId",
            ////            column: x => x.ApplicationId,
            ////            principalTable: "Applications",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////        table.ForeignKey(
            ////            name: "FK_ApplicationPhasesHelpers_Statuses_StatusId",
            ////            column: x => x.StatusId,
            ////            principalTable: "Statuses",
            ////            principalColumn: "Id",
            ////            onDelete: ReferentialAction.Cascade);
            ////    });

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_AdditionalInformations_AppUserId",
            ////    table: "AdditionalInformations",
            ////    column: "AppUserId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_AdditionalInformationTests_AppUserId",
            ////    table: "AdditionalInformationTests",
            ////    column: "AppUserId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_ApplicationPhasesHelpers_ApplicationId",
            ////    table: "ApplicationPhasesHelpers",
            ////    column: "ApplicationId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_ApplicationPhasesHelpers_ApplicationPhaseId",
            ////    table: "ApplicationPhasesHelpers",
            ////    column: "ApplicationPhaseId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_ApplicationPhasesHelpers_StatusId",
            ////    table: "ApplicationPhasesHelpers",
            ////    column: "StatusId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_Applications_AppUserId",
            ////    table: "Applications",
            ////    column: "AppUserId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_Applications_JobId",
            ////    table: "Applications",
            ////    column: "JobId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_Documents_AppUserId",
            ////    table: "Documents",
            ////    column: "AppUserId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_Educations_AppUserId",
            ////    table: "Educations",
            ////    column: "AppUserId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_EducationTests_AppUserId",
            ////    table: "EducationTests",
            ////    column: "AppUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IdealCandidates_CitizenshipId",
            //    table: "IdealCandidates",
            //    column: "CitizenshipId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IdealCandidates_JobId",
            //    table: "IdealCandidates",
            //    column: "JobId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IdealCandidates_JobPlatformId",
            //    table: "IdealCandidates",
            //    column: "JobPlatformId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IdealCandidates_LocationId",
            //    table: "IdealCandidates",
            //    column: "LocationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IdealCandidates_NoticePeriodId",
            //    table: "IdealCandidates",
            //    column: "NoticePeriodId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IdealCandidates_PermissionId",
            //    table: "IdealCandidates",
            //    column: "PermissionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IdealCandidates_VisaId",
            //    table: "IdealCandidates",
            //    column: "VisaId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_IdealCandidates_WorkPermitId",
            //    table: "IdealCandidates",
            //    column: "WorkPermitId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_JobPlatformHelpers_JobID",
            ////    table: "JobPlatformHelpers",
            ////    column: "JobID");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_JobPlatformHelpers_JobPlatformId",
            ////    table: "JobPlatformHelpers",
            ////    column: "JobPlatformId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Jobs_DepartmentId",
            //    table: "Jobs",
            //    column: "DepartmentId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_JobTypeHelpers_JobID",
            ////    table: "JobTypeHelpers",
            ////    column: "JobID");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_JobTypeHelpers_JobTypeID",
            ////    table: "JobTypeHelpers",
            ////    column: "JobTypeID");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_LoginHelpers_AppUserId",
            ////    table: "LoginHelpers",
            ////    column: "AppUserId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_PersonalInformations_AppUserId",
            ////    table: "PersonalInformations",
            ////    column: "AppUserId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_PersonalTestInfos_AppUserId",
            ////    table: "PersonalTestInfos",
            ////    column: "AppUserId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_ProfilePortfolioLinks_AppUserId",
            ////    table: "ProfilePortfolioLinks",
            ////    column: "AppUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questionnaires_AppUserId",
            //    table: "Questionnaires",
            //    column: "AppUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questionnaires_CitizenshipId",
            //    table: "Questionnaires",
            //    column: "CitizenshipId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questionnaires_JobPlatformId",
            //    table: "Questionnaires",
            //    column: "JobPlatformId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questionnaires_LocationId",
            //    table: "Questionnaires",
            //    column: "LocationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questionnaires_NoticePeriodId",
            //    table: "Questionnaires",
            //    column: "NoticePeriodId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questionnaires_PermissionId",
            //    table: "Questionnaires",
            //    column: "PermissionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questionnaires_VisaId",
            //    table: "Questionnaires",
            //    column: "VisaId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Questionnaires_WorkPermitId",
            //    table: "Questionnaires",
            //    column: "WorkPermitId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_RegisterHelpers_AppUserId",
            ////    table: "RegisterHelpers",
            ////    column: "AppUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Results_AppUserId",
            //    table: "Results",
            //    column: "AppUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Results_JobId",
            //    table: "Results",
            //    column: "JobId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_WorkHistories_AppUserId",
            ////    table: "WorkHistories",
            ////    column: "AppUserId");

            ////migrationBuilder.CreateIndex(
            ////    name: "IX_WorkHistoryTests_AppUserId",
            ////    table: "WorkHistoryTests",
            ////    column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalInformations");

            migrationBuilder.DropTable(
                name: "AdditionalInformationTests");

            migrationBuilder.DropTable(
                name: "ApplicationPhasesHelpers");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EducationTests");

            migrationBuilder.DropTable(
                name: "IdealCandidates");

            migrationBuilder.DropTable(
                name: "JobPlatformHelpers");

            migrationBuilder.DropTable(
                name: "JobTypeHelpers");

            migrationBuilder.DropTable(
                name: "LoginHelpers");

            migrationBuilder.DropTable(
                name: "PersonalInformations");

            migrationBuilder.DropTable(
                name: "PersonalTestInfos");

            migrationBuilder.DropTable(
                name: "ProfilePortfolioLinks");

            migrationBuilder.DropTable(
                name: "Questionnaires");

            migrationBuilder.DropTable(
                name: "RegisterHelpers");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "WorkHistories");

            migrationBuilder.DropTable(
                name: "WorkHistoryTests");

            migrationBuilder.DropTable(
                name: "ApplicationPhases");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "Citizenships");

            migrationBuilder.DropTable(
                name: "JobPlatforms");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "NoticePeriods");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Visas");

            migrationBuilder.DropTable(
                name: "WorkPermits");

            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
