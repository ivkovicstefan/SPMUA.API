﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SPMUA.Repository.Data;

#nullable disable

namespace SPMUA.Repository.Migrations
{
    [DbContext(typeof(SpmuaDbContext))]
    partial class SpmuaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SPMUA.Model.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("AdminEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AdminFirstName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("AdminLastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            AdminEmail = "ivkovics@outlook.com",
                            AdminFirstName = "System",
                            AdminLastName = "Admin",
                            PasswordHash = "$2a$11$Ndtpv9XiwY2ydOgZ9.0Pc.NbxY2dOqybAA0JR0Afw8r6gvjbeqjji"
                        });
                });

            modelBuilder.Entity("SPMUA.Model.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AppointmentStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponseComment")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ServiceTypeId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("AppointmentStatusId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("SPMUA.Model.Models.AppointmentStatus", b =>
                {
                    b.Property<int>("AppointmentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentStatusId"));

                    b.Property<string>("AppointmentStatusName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("AppointmentStatusId");

                    b.ToTable("AppointmentStatuses");

                    b.HasData(
                        new
                        {
                            AppointmentStatusId = 1,
                            AppointmentStatusName = "Confirmation Pending",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            AppointmentStatusId = 2,
                            AppointmentStatusName = "Confirmed",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            AppointmentStatusId = 3,
                            AppointmentStatusName = "Rejected",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            AppointmentStatusId = 4,
                            AppointmentStatusName = "Completed",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            AppointmentStatusId = 5,
                            AppointmentStatusName = "Expired",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            AppointmentStatusId = 6,
                            AppointmentStatusName = "Missed",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("SPMUA.Model.Models.EmailTemplate", b =>
                {
                    b.Property<int>("EmailTemplateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmailTemplateId"));

                    b.Property<string>("EmailTemplateHtml")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailTemplateName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmailTemplateTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmailTemplateId");

                    b.ToTable("EmailTemplates");

                    b.HasData(
                        new
                        {
                            EmailTemplateId = 1,
                            EmailTemplateHtml = "<!DOCTYPE html><html lang=\"en\"><head> <meta charset=\"UTF-8\"> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"> <title>Document</title> <style> body { font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; } table { text-align: left; } </style></head><body> <h1>Zahtev za rezervaciju uspešno poslat</h1> <table> <tr> <th>Broj rezervacije</th> <td>{{AppointmentId}}</td> </tr> <tr> <th>Tip usluge</th> <td>{{ServiceTypeName}}</td> </tr> <tr> <th>Ime i prezime</th> <td>{{CustomerFullName}}</td> </tr> <tr> <th>Datum</th> <td>{{AppointmentDate}}</td> </tr> <tr> <th>Termin</th> <td>{{AppointmentTimeInterval}}</td> </tr><tr> <th>Cena</th> <td>{{ServiceTypePrice}}</td> </tr> </table></body></html>",
                            EmailTemplateName = "Appointment Request Confirmation Pending",
                            EmailTemplateTitle = "Zahtev za rezervaciju {{AppointmentId}} uspešno poslat"
                        },
                        new
                        {
                            EmailTemplateId = 2,
                            EmailTemplateHtml = "<!DOCTYPE html><html lang=\"en\"><head> <meta charset=\"UTF-8\"> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"> <title>Document</title> <style> body { font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; } table { text-align: left; } </style></head><body> <h1>Novi zahtev za rezervaciju</h1> <table> <tr> <th>Broj rezervacije</th> <td>{{AppointmentId}}</td> </tr> <tr> <th>Tip usluge</th> <td>{{ServiceTypeName}}</td> </tr> <tr> <th>Ime i prezime</th> <td>{{CustomerFullName}}</td> </tr> <tr> <th>Email adresa</th> <td>{{CustomerEmail}}</td> </tr> <tr> <th>Broj telefona</th> <td>{{CustomerPhone}}</td> </tr> <tr> <th>Datum</th> <td>{{AppointmentDate}}</td> </tr> <tr> <th>Termin</th> <td>{{AppointmentTimeInterval}}</td> </tr><tr> <th>Cena</th> <td>{{ServiceTypePrice}}</td> </tr> </table></body></html>",
                            EmailTemplateName = "Appointment Request Arrived",
                            EmailTemplateTitle = "Novi zahtev za rezervaciju {{AppointmentId}}"
                        },
                        new
                        {
                            EmailTemplateId = 3,
                            EmailTemplateHtml = "<!DOCTYPE html><html lang=\"en\"><head> <meta charset=\"UTF-8\"> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"> <title>Document</title> <style> body { font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; } table { text-align: left; } </style></head><body> <h1>Rezervacija je odobrena</h1> <table> <tr> <th>Broj rezervacije</th> <td>{{AppointmentId}}</td> </tr> <tr> <th>Tip usluge</th> <td>{{ServiceTypeName}}</td> </tr> <tr> <th>Ime i prezime</th> <td>{{CustomerFullName}}</td> </tr> <tr> <th>Datum</th> <td>{{AppointmentDate}}</td> </tr> <tr> <th>Termin</th> <td>{{AppointmentTimeInterval}}</td> </tr><tr> <th>Cena</th> <td>{{ServiceTypePrice}}</td> </tr> <tr> <th>Komentar</th> <td>{{ResponseComment}}</td> </tr> </table></body></html>",
                            EmailTemplateName = "Appointment Request Confirmed",
                            EmailTemplateTitle = "Rezervacija {{AppointmentId}} je odobrena"
                        },
                        new
                        {
                            EmailTemplateId = 4,
                            EmailTemplateHtml = "<!DOCTYPE html><html lang=\"en\"><head> <meta charset=\"UTF-8\"> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"> <title>Document</title> <style> body { font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; } table { text-align: left; } </style></head><body> <h1>Rezervacija je odbijena</h1> <table> <tr> <th>Broj rezervacije</th> <td>{{AppointmentId}}</td> </tr> <tr> <th>Tip usluge</th> <td>{{ServiceTypeName}}</td> </tr> <tr> <th>Ime i prezime</th> <td>{{CustomerFullName}}</td> </tr> <tr> <th>Datum</th> <td>{{AppointmentDate}}</td> </tr> <tr> <th>Termin</th> <td>{{AppointmentTimeInterval}}</td> </tr><tr> <th>Cena</th> <td>{{ServiceTypePrice}}</td> </tr> <tr> <th>Komentar</th> <td>{{ResponseComment}}</td> </tr> </table></body></html>",
                            EmailTemplateName = "Appointment Request Rejected",
                            EmailTemplateTitle = "Rezervacija {{AppointmentId}} je odbijena"
                        });
                });

            modelBuilder.Entity("SPMUA.Model.Models.ServiceType", b =>
                {
                    b.Property<int>("ServiceTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceTypeId"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableOnFriday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableOnMonday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableOnSaturday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableOnSunday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableOnThursday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableOnTuesday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailableOnWednesday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiceTypeDuration")
                        .HasColumnType("int");

                    b.Property<string>("ServiceTypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ServiceTypeId");

                    b.ToTable("ServiceTypes");

                    b.HasData(
                        new
                        {
                            ServiceTypeId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsAvailableOnFriday = true,
                            IsAvailableOnMonday = true,
                            IsAvailableOnSaturday = true,
                            IsAvailableOnSunday = true,
                            IsAvailableOnThursday = true,
                            IsAvailableOnTuesday = true,
                            IsAvailableOnWednesday = true,
                            IsDeleted = false,
                            ServiceTypeDuration = 60,
                            ServiceTypeName = "Makeup"
                        },
                        new
                        {
                            ServiceTypeId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsAvailableOnFriday = true,
                            IsAvailableOnMonday = true,
                            IsAvailableOnSaturday = false,
                            IsAvailableOnSunday = false,
                            IsAvailableOnThursday = true,
                            IsAvailableOnTuesday = true,
                            IsAvailableOnWednesday = true,
                            IsDeleted = false,
                            ServiceTypeDuration = 60,
                            ServiceTypeName = "Brow lift"
                        },
                        new
                        {
                            ServiceTypeId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsAvailableOnFriday = true,
                            IsAvailableOnMonday = true,
                            IsAvailableOnSaturday = false,
                            IsAvailableOnSunday = false,
                            IsAvailableOnThursday = true,
                            IsAvailableOnTuesday = true,
                            IsAvailableOnWednesday = true,
                            IsDeleted = false,
                            ServiceTypeDuration = 90,
                            ServiceTypeName = "Lash lift"
                        },
                        new
                        {
                            ServiceTypeId = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsAvailableOnFriday = true,
                            IsAvailableOnMonday = true,
                            IsAvailableOnSaturday = false,
                            IsAvailableOnSunday = false,
                            IsAvailableOnThursday = true,
                            IsAvailableOnTuesday = true,
                            IsAvailableOnWednesday = true,
                            IsDeleted = false,
                            ServiceTypeDuration = 90,
                            ServiceTypeName = "Brow & Lash lift"
                        });
                });

            modelBuilder.Entity("SPMUA.Model.Models.ServiceTypePriceHistory", b =>
                {
                    b.Property<int>("ServiceTypePriceHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceTypePriceHistoryId"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiceTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("ServiceTypePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ServiceTypePriceHistoryId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("ServiceTypePriceHistory");

                    b.HasData(
                        new
                        {
                            ServiceTypePriceHistoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceTypeId = 1,
                            ServiceTypePrice = 2400.00m
                        },
                        new
                        {
                            ServiceTypePriceHistoryId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceTypeId = 2,
                            ServiceTypePrice = 1500.00m
                        },
                        new
                        {
                            ServiceTypePriceHistoryId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceTypeId = 3,
                            ServiceTypePrice = 1700.00m
                        },
                        new
                        {
                            ServiceTypePriceHistoryId = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ServiceTypeId = 4,
                            ServiceTypePrice = 3000.00m
                        });
                });

            modelBuilder.Entity("SPMUA.Model.Models.Vacation", b =>
                {
                    b.Property<int>("VacationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacationId"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VacationName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("VacationId");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("SPMUA.Model.Models.WorkingDay", b =>
                {
                    b.Property<int>("WorkingDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkingDayId"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("EndTime")
                        .HasColumnType("time");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("StartTime")
                        .HasColumnType("time");

                    b.Property<string>("WorkingDayName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("WorkingDayId");

                    b.ToTable("WorkingDays");

                    b.HasData(
                        new
                        {
                            WorkingDayId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            WorkingDayName = "Ponedeljak"
                        },
                        new
                        {
                            WorkingDayId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            WorkingDayName = "Utorak"
                        },
                        new
                        {
                            WorkingDayId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            WorkingDayName = "Sreda"
                        },
                        new
                        {
                            WorkingDayId = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            WorkingDayName = "Četvrtak"
                        },
                        new
                        {
                            WorkingDayId = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            WorkingDayName = "Petak"
                        },
                        new
                        {
                            WorkingDayId = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 7, 0, 0, 0),
                            WorkingDayName = "Subota"
                        },
                        new
                        {
                            WorkingDayId = 7,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 7, 0, 0, 0),
                            WorkingDayName = "Nedelja"
                        });
                });

            modelBuilder.Entity("SPMUA.Model.Models.Appointment", b =>
                {
                    b.HasOne("SPMUA.Model.Models.AppointmentStatus", "AppointmentStatus")
                        .WithMany("Appointment")
                        .HasForeignKey("AppointmentStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SPMUA.Model.Models.ServiceType", "ServiceType")
                        .WithMany("Appointment")
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppointmentStatus");

                    b.Navigation("ServiceType");
                });

            modelBuilder.Entity("SPMUA.Model.Models.ServiceTypePriceHistory", b =>
                {
                    b.HasOne("SPMUA.Model.Models.ServiceType", null)
                        .WithMany("ServiceTypePriceHistories")
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SPMUA.Model.Models.AppointmentStatus", b =>
                {
                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("SPMUA.Model.Models.ServiceType", b =>
                {
                    b.Navigation("Appointment");

                    b.Navigation("ServiceTypePriceHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
