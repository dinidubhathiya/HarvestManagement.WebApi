﻿// <auto-generated />
using System;
using Hectre.HarvestManagement.DataPersistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hectre.HarvestManagement.DataPersistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230805025644_updateHavestDTO")]
    partial class updateHavestDTO
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hectre.HarvestManagement.Core.Models.Harvest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("BinCount")
                        .HasColumnType("bigint");

                    b.Property<float>("HourlyWageRate")
                        .HasColumnType("real");

                    b.Property<float>("HoursWorked")
                        .HasColumnType("real");

                    b.Property<Guid>("OrchardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PickerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PickingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SupervisorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Variety")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrchardId");

                    b.ToTable("Harvests");
                });

            modelBuilder.Entity("Hectre.HarvestManagement.Core.Models.Orchard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Block")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubBlock")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orchards");
                });

            modelBuilder.Entity("Hectre.HarvestManagement.Core.Models.Timesheet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Activity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrchardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PickerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SupervisorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrchardId");

                    b.ToTable("Timesheets");
                });

            modelBuilder.Entity("Hectre.HarvestManagement.Core.Models.Harvest", b =>
                {
                    b.HasOne("Hectre.HarvestManagement.Core.Models.Orchard", "Orchard")
                        .WithMany()
                        .HasForeignKey("OrchardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orchard");
                });

            modelBuilder.Entity("Hectre.HarvestManagement.Core.Models.Timesheet", b =>
                {
                    b.HasOne("Hectre.HarvestManagement.Core.Models.Orchard", "Orchard")
                        .WithMany()
                        .HasForeignKey("OrchardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orchard");
                });
#pragma warning restore 612, 618
        }
    }
}
