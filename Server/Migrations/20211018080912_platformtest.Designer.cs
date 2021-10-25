﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Data;

namespace XebecPortal.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211018080912_platformtest")]
    partial class platformtest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("XebecPortal.Shared.AdditionalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacebookLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GitHubLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedInLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalWebsiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AdditionalInformations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GitHubLink = "https://github.com/johnsnowwygot",
                            LinkedInLink = "https://linkedIn.com/snowy",
                            PersonalWebsiteUrl = "https://jphnsnow.com ",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeApplied")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            JobId = 1,
                            TimeApplied = new DateTime(2021, 10, 18, 10, 11, 10, 572, DateTimeKind.Local).AddTicks(5523),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.ApplicationPhase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationPhases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Phone Screen"
                        },
                        new
                        {
                            Id = 2,
                            Description = "First Interview"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Second Interview"
                        },
                        new
                        {
                            Id = 4,
                            Description = "CEO Final Interview"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Offer Sent"
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.ApplicationPhaseHelper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int?>("ApplicationPhaseId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhaseId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeMoved")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("ApplicationPhaseId");

                    b.ToTable("ApplicationPhasesHelpers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationId = 1,
                            Comments = "Good Candidate, has potential to rule all of Westeros",
                            PhaseId = 1,
                            StatusId = 1,
                            TimeMoved = new DateTime(2021, 10, 18, 10, 9, 10, 576, DateTimeKind.Local).AddTicks(1892)
                        },
                        new
                        {
                            Id = 2,
                            ApplicationId = 1,
                            Comments = "Interview went well, He's really got potential",
                            PhaseId = 2,
                            StatusId = 1,
                            TimeMoved = new DateTime(2021, 10, 20, 10, 9, 10, 576, DateTimeKind.Local).AddTicks(2511)
                        },
                        new
                        {
                            Id = 3,
                            ApplicationId = 1,
                            Comments = "He's good, but won't become king",
                            PhaseId = 3,
                            StatusId = 2,
                            TimeMoved = new DateTime(2021, 12, 18, 10, 9, 10, 576, DateTimeKind.Local).AddTicks(2587)
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DocumentName = "CV",
                            DocumentUrl = "https://johnsnowsociety.org"
                        },
                        new
                        {
                            Id = 2,
                            DocumentName = "Drivers license",
                            DocumentUrl = "https://johnsnowdrivers.com"
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.DocumentHelper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("UserId");

                    b.ToTable("DocumentHelpers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DocumentId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DocumentId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Insitution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2021, 12, 18, 10, 9, 10, 577, DateTimeKind.Local).AddTicks(7637),
                            Insitution = "Richmond",
                            Qualification = "BSc Computer Science",
                            StartDate = new DateTime(2021, 10, 18, 10, 9, 12, 577, DateTimeKind.Local).AddTicks(6801)
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2022, 12, 18, 10, 9, 10, 577, DateTimeKind.Local).AddTicks(9471),
                            Insitution = "Hogwarts",
                            Qualification = "HighSchool Diploma",
                            StartDate = new DateTime(2021, 10, 18, 10, 11, 10, 577, DateTimeKind.Local).AddTicks(9457)
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.EducationHelper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EducationId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("UserId");

                    b.ToTable("EducationHelpers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EducationId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            EducationId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Compensation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Compensation = "R45000",
                            CreationDate = new DateTime(2021, 10, 18, 10, 9, 10, 566, DateTimeKind.Local).AddTicks(818),
                            Department = "IT",
                            Description = "blah! blah! blah!",
                            DueDate = new DateTime(2021, 12, 18, 10, 9, 10, 564, DateTimeKind.Local).AddTicks(1387),
                            Location = "JHB",
                            Title = "Developer"
                        },
                        new
                        {
                            Id = 2,
                            Compensation = "R50000",
                            CreationDate = new DateTime(2021, 10, 18, 10, 9, 10, 566, DateTimeKind.Local).AddTicks(1718),
                            Department = "IT",
                            Description = "beep! beep beep!",
                            DueDate = new DateTime(2021, 11, 18, 10, 9, 10, 566, DateTimeKind.Local).AddTicks(1684),
                            Location = "DBN",
                            Title = "Mobile Administrator"
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.JobPlatform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlatformName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobPlatforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PlatformName = "LinkedIn"
                        },
                        new
                        {
                            Id = 2,
                            PlatformName = "Indeed"
                        },
                        new
                        {
                            Id = 3,
                            PlatformName = "Twitter"
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.JobPlatformHelper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JobID")
                        .HasColumnType("int");

                    b.Property<int>("JobPlatformId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobID");

                    b.HasIndex("JobPlatformId");

                    b.ToTable("JobPlatformHelpers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            JobID = 1,
                            JobPlatformId = 1
                        },
                        new
                        {
                            Id = 2,
                            JobID = 2,
                            JobPlatformId = 2
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.JobType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Full-Time"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Part-Time"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Internship"
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.JobTypeHelper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JobID")
                        .HasColumnType("int");

                    b.Property<int>("JobTypeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("JobID");

                    b.HasIndex("JobTypeID");

                    b.ToTable("JobTypeHelpers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            JobID = 1,
                            JobTypeID = 1
                        },
                        new
                        {
                            Id = 2,
                            JobID = 1,
                            JobTypeID = 2
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.LoginHelper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TimeDateLogOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeDateLogin")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("LoginHelpers");
                });

            modelBuilder.Entity("XebecPortal.Shared.PersonalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disability")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ethnicity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PersonalInformations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "2 Winter Fell Road",
                            Disability = false,
                            Ethnicity = "Wildling",
                            FirstName = "John",
                            Gender = "male",
                            IdNumber = "74102589631",
                            LastName = "Snow",
                            PhoneNumber = "0329434578",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.RegisterHelper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TimeDateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RegisterHelpers");
                });

            modelBuilder.Entity("XebecPortal.Shared.Security.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("XebecPortal.Shared.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "In Progress"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Regreted"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Hired"
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "sample@gmail.com",
                            PasswordHash = "2526sgfgfhsgdf984894s",
                            Role = "Candidate"
                        },
                        new
                        {
                            Id = 2,
                            Email = "analyst@test.com",
                            PasswordHash = "1538sgligrand9845sds",
                            Role = "Analyst"
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.WorkHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WorkHistories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "White Wolf Inc",
                            Description = "Commanded an army to victory",
                            EndDate = new DateTime(2023, 10, 18, 10, 9, 10, 582, DateTimeKind.Local).AddTicks(5945),
                            JobTitle = "Commander",
                            StartDate = new DateTime(2021, 10, 18, 10, 9, 10, 582, DateTimeKind.Local).AddTicks(5159)
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Westeros Pty Ltd",
                            Description = "Daydreaming on a Sunday afternoon",
                            EndDate = new DateTime(2024, 10, 18, 10, 9, 10, 582, DateTimeKind.Local).AddTicks(8191),
                            JobTitle = "King",
                            StartDate = new DateTime(2022, 10, 18, 10, 9, 10, 582, DateTimeKind.Local).AddTicks(8170)
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.WorkHistoryHelper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("WorkHistoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkHistoryId");

                    b.ToTable("WorkHistoryHelpers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1,
                            WorkHistoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 1,
                            WorkHistoryId = 2
                        });
                });

            modelBuilder.Entity("XebecPortal.Shared.AdditionalInformation", b =>
                {
                    b.HasOne("XebecPortal.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("XebecPortal.Shared.Application", b =>
                {
                    b.HasOne("XebecPortal.Shared.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XebecPortal.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XebecPortal.Shared.ApplicationPhaseHelper", b =>
                {
                    b.HasOne("XebecPortal.Shared.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XebecPortal.Shared.ApplicationPhase", "ApplicationPhase")
                        .WithMany()
                        .HasForeignKey("ApplicationPhaseId");

                    b.Navigation("Application");

                    b.Navigation("ApplicationPhase");
                });

            modelBuilder.Entity("XebecPortal.Shared.DocumentHelper", b =>
                {
                    b.HasOne("XebecPortal.Shared.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XebecPortal.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XebecPortal.Shared.EducationHelper", b =>
                {
                    b.HasOne("XebecPortal.Shared.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XebecPortal.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Education");

                    b.Navigation("User");
                });

            modelBuilder.Entity("XebecPortal.Shared.JobPlatformHelper", b =>
                {
                    b.HasOne("XebecPortal.Shared.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XebecPortal.Shared.JobPlatform", "JobPlatform")
                        .WithMany()
                        .HasForeignKey("JobPlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("JobPlatform");
                });

            modelBuilder.Entity("XebecPortal.Shared.JobTypeHelper", b =>
                {
                    b.HasOne("XebecPortal.Shared.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XebecPortal.Shared.JobType", "JobType")
                        .WithMany()
                        .HasForeignKey("JobTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");

                    b.Navigation("JobType");
                });

            modelBuilder.Entity("XebecPortal.Shared.LoginHelper", b =>
                {
                    b.HasOne("XebecPortal.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("XebecPortal.Shared.PersonalInformation", b =>
                {
                    b.HasOne("XebecPortal.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("XebecPortal.Shared.RegisterHelper", b =>
                {
                    b.HasOne("XebecPortal.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("XebecPortal.Shared.WorkHistoryHelper", b =>
                {
                    b.HasOne("XebecPortal.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("XebecPortal.Shared.WorkHistory", "WorkHistory")
                        .WithMany()
                        .HasForeignKey("WorkHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("WorkHistory");
                });
#pragma warning restore 612, 618
        }
    }
}