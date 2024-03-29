﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SPMUA.Repository.Data;

#nullable disable

namespace SPMUA.Repository.Migrations
{
    [DbContext(typeof(SpmuaDbContext))]
    [Migration("20230505194651_RenameServicesTableToServiceTypes")]
    partial class RenameServicesTableToServiceTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                        .IsRequired()
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
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("AppointmentStatusId");

                    b.HasIndex("ServiceId");

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
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmailTemplateTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmailTemplateId");

                    b.ToTable("EmailTemplates");
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

                    b.Property<decimal>("ServiceTypePrice")
                        .HasColumnType("decimal(18,2)");

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
                            ServiceTypeName = "Makeup",
                            ServiceTypePrice = 2400.00m
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
                            ServiceTypeName = "Brow lift",
                            ServiceTypePrice = 1500.00m
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
                            ServiceTypeName = "Lash lift",
                            ServiceTypePrice = 1700.00m
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
                            ServiceTypeName = "Brow & Lash lift",
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

                    b.Property<DateTime>("VacationEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VacationName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("VacationStartDate")
                        .HasColumnType("datetime2");

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
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

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
                            WorkingDayName = "Monday"
                        },
                        new
                        {
                            WorkingDayId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            WorkingDayName = "Tuesday"
                        },
                        new
                        {
                            WorkingDayId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            WorkingDayName = "Wednesday"
                        },
                        new
                        {
                            WorkingDayId = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            WorkingDayName = "Thursday"
                        },
                        new
                        {
                            WorkingDayId = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 16, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 10, 0, 0, 0),
                            WorkingDayName = "Friday"
                        },
                        new
                        {
                            WorkingDayId = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 7, 0, 0, 0),
                            WorkingDayName = "Saturday"
                        },
                        new
                        {
                            WorkingDayId = 7,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            IsActive = true,
                            IsDeleted = false,
                            StartTime = new TimeSpan(0, 7, 0, 0, 0),
                            WorkingDayName = "Sunday"
                        });
                });

            modelBuilder.Entity("SPMUA.Model.Models.Appointment", b =>
                {
                    b.HasOne("SPMUA.Model.Models.AppointmentStatus", "AppointmentStatus")
                        .WithMany("Appointment")
                        .HasForeignKey("AppointmentStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SPMUA.Model.Models.ServiceType", "Service")
                        .WithMany("Appointment")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppointmentStatus");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("SPMUA.Model.Models.AppointmentStatus", b =>
                {
                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("SPMUA.Model.Models.ServiceType", b =>
                {
                    b.Navigation("Appointment");
                });
#pragma warning restore 612, 618
        }
    }
}
